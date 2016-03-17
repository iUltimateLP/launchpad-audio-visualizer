using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchpadNET;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.BassWasapi;
using System.Windows.Threading;

namespace launchpad_audio_vis
{
    public class AudioAnalyzer
    {
        private Interface _lInt;
        private Interface.LaunchpadDevice _currentLaunchpad;

        private MainWindow windowInst;

        private bool _enable;
        private float[] _fft;
        private DispatcherTimer _t;
        private WASAPIPROC _process;
        private int _lastlevel;
        private int _hanctr;
        private List<byte> _spectrumdata;
        private bool _initialized;
        private int devindex;
        private SoftwareVisualizer _vis;
        private bool useSoftwareVis;

        private float _val;
        private float _ledY;

        private Dictionary<string, int> colors = new Dictionary<string, int> {
            {"Red", 72},
            {"Green", 63},
            {"Yellow", 13},
            {"Orange", 9},
            {"Blue", 41},
            {"LightBlue", 36},
            {"White", 3},
            {"Lime", 17}
        };
        private Dictionary<float, string> colorThreshhold = new Dictionary<float, string> {
            {30, "Lime"},
            {90, "Green"},
            {130, "Yellow"},
            {180, "Orange"},
            {220, "Red"}
        };

        private int[,] leds;

        public AudioAnalyzer(MainWindow inst)
        {
            windowInst = inst;

            _lInt = new Interface();

            _fft = new float[1024];
            _lastlevel = 0;
            _hanctr = 0;
            _t = new DispatcherTimer();
            _t.Tick += timerTick;
            _t.Interval = TimeSpan.FromMilliseconds(25);
            _t.IsEnabled = false;
            _process = new WASAPIPROC(Process);
            _spectrumdata = new List<byte>();
            _vis = inst.visualizer;
            _initialized = false;
            //Init();

            leds = new int[8, 8];

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    leds[x, y] = 0;
                }
            }
        }

        public bool Enable
        {
            get { return _enable; }
            set
            {
                _enable = value;
                if (value)
                {
                    if (!_initialized)
                    {
                        var array = (windowInst.devicesCombo.Items[windowInst.devicesCombo.SelectedIndex] as string).Split(' ');
                        devindex = Convert.ToInt32(array[0]);
                        bool result = BassWasapi.BASS_WASAPI_Init(devindex, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, _process, IntPtr.Zero);
                        if (!result)
                        {
                            var error = Bass.BASS_ErrorGetCode();
                            MessageBox.Show("BassAPI returned the following error:\n" + error.ToString(), "Bass Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            _initialized = true;
                            windowInst.devicesCombo.IsEnabled = false;
                        }
                    }
                    BassWasapi.BASS_WASAPI_Start();
                }
                else BassWasapi.BASS_WASAPI_Stop(true);
                System.Threading.Thread.Sleep(500);
                _t.IsEnabled = value;
            }
        }

        private void Init()
        {
            bool result = false;
            for (int i = 0; i < BassWasapi.BASS_WASAPI_GetDeviceCount(); i++)
            {
                var device = BassWasapi.BASS_WASAPI_GetDeviceInfo(i);
                if (device.IsEnabled && device.IsLoopback)
                {
                    windowInst.devicesCombo.Items.Add(string.Format("{0} - {1}", i, device.name));
                }
            }
            windowInst.devicesCombo.SelectedIndex = 0;
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATEPERIOD, false);
            result = Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            if (!result) throw new Exception("Init error!");
        }

        private void timerTick(object sender, EventArgs e)
        {
            int ret = BassWasapi.BASS_WASAPI_GetData(_fft, (int)BASSData.BASS_DATA_FFT2048);
            if (ret < -1) return;
            int x, y;
            int b0 = 0;

            //8 = Launchpad line count
            for (x = 0; x < 8; x++)
            {
                float peak = 0;
                int b1 = (int)Math.Pow(2, x * 10.0 / (8 - 1));
                if (b1 > 1023) b1 = 1023;
                if (b1 <= b0) b1 = b0 + 1;
                for (; b0 < b1; b0++)
                {
                    if (peak < _fft[1 + b0]) peak = _fft[1 + b0];
                }
                y = (int)(Math.Sqrt(peak) * 3 * 255 - 4);
                if (y > 255) y = 255;
                if (y < 0) y = 0;
                _spectrumdata.Add((byte)y);
            }

            //Software Visualization
            if (useSoftwareVis) _vis.SetData(_spectrumdata);

            //Launchpad Serialization here
            if (_lInt != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    _val = ((float)_spectrumdata[i] / 255) * 8;
                    _ledY = _val >= 8 ? 7 : _val;
                    int v = GetVelocityForVolume(_spectrumdata[i]);

                    for (int tX = 1; tX <= 8; tX++)
                    {
                        for (int tY = 1; tY <= 8; tY++)
                        {
                            int veloAtThisPoint = leds[tX-1, tY-1];
                            if (tX == i+1 && tY == 8-(int)_ledY)
                            {
                                _lInt.fillLEDs(tX, 8 - (int)_ledY, tX, 8, v); //Write Color Track
                                if (8 - (int)_ledY != 8 && 8 - (int)_ledY != 1) //Write it only if it is not 8th or 1st LED (which causes flickering)
                                {
                                    _lInt.fillLEDs(tX, 1, tX, 8 - (int)_ledY, 0); //Write zero track (inverse of color track)
                                }
                                leds[tX - 1, tY - 1] = v;
                            }
                        }
                    }
                }
            }

            _spectrumdata.Clear();

            int level = BassWasapi.BASS_WASAPI_GetLevel();
            if (level == _lastlevel && level != 0) _hanctr++;
            _lastlevel = level;

            if (_hanctr > 3)
            {
                _hanctr = 0;
                Free();
                Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                _initialized = false;
                Enable = true;
            }
        }

        private int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        public void Free()
        {
            BassWasapi.BASS_WASAPI_Free();
            Bass.BASS_Free();
        }

        public Interface GetInterface()
        {
            return _lInt;
        }

        public void SetCurrentLaunchpad(Interface.LaunchpadDevice device)
        {
            Console.WriteLine("Connecting to '" + device._midiName + "'");
            _currentLaunchpad = device;
            if (_lInt.connect(_currentLaunchpad))
            {
                _lInt.clearAllLEDs();
                //_lInt.createTextScroll("Connected", 8, false, 127);
            }
            else
            {
                MessageBox.Show("There was an error connecting to your Launchpad.\nMake sure this device isn't used by any other app!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetCurrentLaunchpad(string deviceName)
        {
            foreach(Interface.LaunchpadDevice d in _lInt.getConnectedLaunchpads())
            {
                if (d._midiName == deviceName)
                {
                    SetCurrentLaunchpad(d);
                }
            }
        }

        public Interface.LaunchpadDevice GetCurrentLaunchpad()
        {
            return _currentLaunchpad;
        }

        public void EnableSoftwareVis(bool state)
        {
            useSoftwareVis = state;
        }

        public bool isLaunchpadConnected()
        {
            return _currentLaunchpad == null;
        }

        public void DisconnectLaunchpad()
        {
            if (_currentLaunchpad != null)
            {
                Console.WriteLine("Disconnecting..");
                _lInt.clearAllLEDs();
                _lInt.disconnect(_currentLaunchpad);
            }
        }

        public int GetVelocityForVolume(int volume)
        {
            Tuple<float, KeyValuePair<float, string>> bestMatch = null;
            foreach (var item in colorThreshhold)
            {
                var dif = Math.Abs(item.Key - volume);
                if (bestMatch == null || dif < bestMatch.Item1)
                    bestMatch = Tuple.Create(dif, item);
            }
            return colors[bestMatch.Item2.Value];
        }
    }
}
