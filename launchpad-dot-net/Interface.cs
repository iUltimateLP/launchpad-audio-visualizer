using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midi;

namespace LaunchpadNET
{
    public class Interface
    {
/*private Pitch[,] notes = new Pitch[8, 8] {
            { Pitch.CNeg1, Pitch.CSharpNeg1, Pitch.DNeg1, Pitch.DSharpNeg1, Pitch.ENeg1, Pitch.FNeg1, Pitch.FSharpNeg1, Pitch.GNeg1 },
            { Pitch.ENeg1, Pitch.FNeg1, Pitch.FSharpNeg1, Pitch.GNeg1, Pitch.GSharpNeg1, Pitch.ANeg1, Pitch.ASharpNeg1, Pitch.BNeg1 },
            { Pitch.GSharp0, Pitch.A0, Pitch.ASharp0, Pitch.B0, Pitch.C1, Pitch.CSharp1, Pitch.D1, Pitch.DSharp1 },
            { Pitch.C2, Pitch.CSharp2, Pitch.D2, Pitch.DSharp2, Pitch.E2, Pitch.F2, Pitch.FSharp2, Pitch.G2 },
            { Pitch.E3, Pitch.F3, Pitch.FSharp3, Pitch.G3, Pitch.GSharp3, Pitch.A3, Pitch.ASharp3, Pitch.B3 },
            { Pitch.GSharp6, Pitch.A4, Pitch.ASharp4, Pitch.B4, Pitch.C5, Pitch.CSharp5, Pitch.D5, Pitch.DSharp5 },
            { Pitch.C6, Pitch.CSharp6, Pitch.D6, Pitch.DSharp6, Pitch.E6, Pitch.F6, Pitch.FSharp6, Pitch.G6 },
            { Pitch.E7, Pitch.F7, Pitch.FSharp7, Pitch.C7, Pitch.CSharp7, Pitch.A7, Pitch.ASharp7, Pitch.B7 }
        };*/
/*private Pitch[,] notes = new Pitch[8, 8] {
            { Pitch.CNeg1, Pitch.CSharpNeg1, Pitch.DNeg1, Pitch.DSharpNeg1, Pitch.ENeg1, Pitch.FNeg1, Pitch.FSharpNeg1, Pitch.GNeg1 },
            { Pitch.ENeg1, Pitch.FNeg1, Pitch.FSharpNeg1, Pitch.GNeg1, Pitch.GSharpNeg1, Pitch.ANeg1, Pitch.ASharpNeg1, Pitch.BNeg1 },
            { Pitch.GSharp0, Pitch.A0, Pitch.ASharp0, Pitch.B0, Pitch.C1, Pitch.CSharp1, Pitch.D1, Pitch.DSharp1 },
            { Pitch.C2, Pitch.CSharp2, Pitch.D2, Pitch.DSharp2, Pitch.E2, Pitch.F2, Pitch.FSharp2, Pitch.G2 },
            { Pitch.E3, Pitch.F3, Pitch.FSharp3, Pitch.G3, Pitch.GSharp3, Pitch.A3, Pitch.ASharp3, Pitch.B3 },
            { Pitch.GSharp4, Pitch.A4, Pitch.ASharp4, Pitch.B4, Pitch.C5, Pitch.CSharp5, Pitch.D5, Pitch.DSharp5 },
            { Pitch.C6, Pitch.CSharp6, Pitch.D6, Pitch.DSharp6, Pitch.E6, Pitch.F6, Pitch.FSharp6, Pitch.G6 },
            { Pitch.E7, Pitch.F7, Pitch.FSharp7, Pitch.C7, Pitch.CSharp7, Pitch.A7, Pitch.ASharp7, Pitch.B7 }
        };*/

       /* private Pitch[,] notes = new Pitch[8, 8] {
            { Pitch.E7, Pitch.F7, Pitch.FSharp7, Pitch.C7, Pitch.CSharp7, Pitch.A7, Pitch.ASharp7, Pitch.B7 },
            { Pitch.C6, Pitch.CSharp6, Pitch.D6, Pitch.DSharp6, Pitch.E6, Pitch.F6, Pitch.FSharp6, Pitch.G6 },
            { Pitch.GSharp4, Pitch.A4, Pitch.ASharp4, Pitch.B4, Pitch.C5, Pitch.CSharp5, Pitch.D5, Pitch.DSharp5 },
            { Pitch.E3, Pitch.F3, Pitch.FSharp3, Pitch.G3, Pitch.GSharp3, Pitch.A3, Pitch.ASharp3, Pitch.B3 },
            { Pitch.C2, Pitch.CSharp2, Pitch.D2, Pitch.DSharp2, Pitch.E2, Pitch.F2, Pitch.FSharp2, Pitch.G2 },
            { Pitch.GSharp0, Pitch.A0, Pitch.ASharp0, Pitch.B0, Pitch.C1, Pitch.CSharp1, Pitch.D1, Pitch.DSharp1 },
            { Pitch.ENeg1, Pitch.FNeg1, Pitch.FSharpNeg1, Pitch.GNeg1, Pitch.GSharpNeg1, Pitch.ANeg1, Pitch.ASharpNeg1, Pitch.BNeg1 },
            { Pitch.CNeg1, Pitch.CSharpNeg1, Pitch.DNeg1, Pitch.DSharpNeg1, Pitch.ENeg1, Pitch.FNeg1, Pitch.FSharpNeg1, Pitch.GNeg1 },
        };*/


/*private Pitch[,] notes = new Pitch[8, 8] {
             { (Pitch)7,(Pitch)6,(Pitch)5,(Pitch)4,(Pitch)3,(Pitch)2,(Pitch)1,(Pitch)0 },
             { (Pitch)11,(Pitch)10,(Pitch)9,(Pitch)8,(Pitch)7,(Pitch)6,(Pitch)5,(Pitch)4 },
             { (Pitch)27,(Pitch)26,(Pitch)25,(Pitch)24,(Pitch)23,(Pitch)22,(Pitch)21,(Pitch)20 },
             { (Pitch)42,(Pitch)41,(Pitch)40,(Pitch)40,(Pitch)39,(Pitch)38,(Pitch)37,(Pitch)36 },
             { (Pitch)59,(Pitch)58,(Pitch)57,(Pitch)56,(Pitch)55,(Pitch)54,(Pitch)53,(Pitch)52 },
             { (Pitch)75,(Pitch)74,(Pitch)73,(Pitch)72,(Pitch)71,(Pitch)70,(Pitch)69,(Pitch)68 },
             { (Pitch)91,(Pitch)90,(Pitch)89,(Pitch)88,(Pitch)87,(Pitch)86,(Pitch)85,(Pitch)84 },
             { (Pitch)107,(Pitch)106,(Pitch)105,(Pitch)104,(Pitch)103,(Pitch)102,(Pitch)101,(Pitch)100 }
         };*/

      /*  private Pitch[,] notes = new Pitch[8, 8] {
            { (Pitch)107,(Pitch)106,(Pitch)105,(Pitch)104,(Pitch)103,(Pitch)102,(Pitch)101,(Pitch)100 },
            { (Pitch)91,(Pitch)90,(Pitch)89,(Pitch)88,(Pitch)87,(Pitch)86,(Pitch)85,(Pitch)84 },
            { (Pitch)75,(Pitch)74,(Pitch)73,(Pitch)72,(Pitch)71,(Pitch)70,(Pitch)69,(Pitch)68 },
            { (Pitch)59,(Pitch)58,(Pitch)57,(Pitch)56,(Pitch)55,(Pitch)54,(Pitch)53,(Pitch)52 },
            { (Pitch)42,(Pitch)41,(Pitch)40,(Pitch)40,(Pitch)39,(Pitch)38,(Pitch)37,(Pitch)36 },
            { (Pitch)27,(Pitch)26,(Pitch)25,(Pitch)24,(Pitch)23,(Pitch)22,(Pitch)21,(Pitch)20 },
            { (Pitch)11,(Pitch)10,(Pitch)9,(Pitch)8,(Pitch)7,(Pitch)6,(Pitch)5,(Pitch)4 },
            { (Pitch)7,(Pitch)6,(Pitch)5,(Pitch)4,(Pitch)3,(Pitch)2,(Pitch)1,(Pitch)0 },
             
             
             
             
             
             
             
         };*/

        private Pitch[,] notes = new Pitch[8, 8] {
                      { (Pitch)0, (Pitch)1, (Pitch)2, (Pitch)3, (Pitch)4, (Pitch)5, (Pitch)6, (Pitch)7 },
                      { (Pitch)16, (Pitch)17, (Pitch)18, (Pitch)19, (Pitch)20, (Pitch)21, (Pitch)22, (Pitch)23 },
                      { (Pitch)32, (Pitch)33, (Pitch)34, (Pitch)35, (Pitch)36, (Pitch)37, (Pitch)38, (Pitch)39 },
                      { (Pitch)48, (Pitch)49, (Pitch)50, (Pitch)51, (Pitch)52, (Pitch)53, (Pitch)54, (Pitch)55 },
                      { (Pitch)64, (Pitch)65, (Pitch)66, (Pitch)67, (Pitch)68, (Pitch)69, (Pitch)70, (Pitch)71 },
                      { (Pitch)80, (Pitch)81, (Pitch)82, (Pitch)83, (Pitch)84, (Pitch)85, (Pitch)86, (Pitch)87 },
                      { (Pitch)96, (Pitch)97, (Pitch)98, (Pitch)99, (Pitch)100, (Pitch)101, (Pitch)102, (Pitch)103 },
                      { (Pitch)112, (Pitch)113, (Pitch)114, (Pitch)115, (Pitch)116, (Pitch)117, (Pitch)118, (Pitch)119 },
};

        /*private Pitch[,] notes = new Pitch[8, 8] {
            { Pitch.A5, Pitch.ASharp5, Pitch.B5, Pitch.C6, Pitch.CSharp6, Pitch.D6, Pitch.DSharp6, Pitch.E6 },
            { Pitch.B4, Pitch.C5, Pitch.CSharp5, Pitch.D5, Pitch.DSharp5, Pitch.E5, Pitch.F5, Pitch.FSharp5 },
            { Pitch.CSharp4, Pitch.D4, Pitch.DSharp4, Pitch.E4, Pitch.F4, Pitch.FSharp4, Pitch.G4, Pitch.GSharp4 },
            { Pitch.DSharp3, Pitch.E3, Pitch.F3, Pitch.FSharp3, Pitch.G3, Pitch.GSharp3, Pitch.A3, Pitch.ASharp3 },
            { Pitch.F2, Pitch.FSharp2, Pitch.G2, Pitch.GSharp2, Pitch.A2, Pitch.ASharp2, Pitch.B2, Pitch.C3 },
            { Pitch.G1, Pitch.GSharp1, Pitch.A1, Pitch.ASharp1, Pitch.B1, Pitch.C2, Pitch.CSharp2, Pitch.D2 },
            { Pitch.A0, Pitch.ASharp0, Pitch.B0, Pitch.C1, Pitch.CSharp1, Pitch.D1, Pitch.DSharp1, Pitch.E1 },
            { Pitch.BNeg1, Pitch.C0, Pitch.CSharp0, Pitch.D0, Pitch.DSharp0, Pitch.E0, Pitch.F0, Pitch.FSharp0 }
        };*/
        /* private byte[,] decimalNotes = new byte[8, 8]
                {
                    { 81, 82, 83, 84, 85, 86, 87, 88 },
                    { 71, 72, 73, 74, 75, 76, 77, 78 },
                    { 61, 62, 63, 64, 65, 66, 67, 68 },
                    { 51, 52, 53, 54, 55, 56, 57, 58 },
                    { 41, 42, 43, 44, 45, 46, 47, 48 },
                    { 31, 32, 33, 34, 35, 36, 37, 38 },
                    { 21, 22, 23, 30, 25, 26, 27, 28 },
                    { 11, 12, 13, 30, 30, 30, 17, 18 },
                };*/

        private byte[,] decimalNotes = new byte[8, 8]
          {
                      { 0, 1, 2, 3, 4, 5, 6, 7 },
                      { 16, 17, 18, 19, 20, 21, 22, 23 },
                      { 32, 33, 34, 35, 36, 37, 38, 39 },
                      { 48, 49, 50, 51, 52, 53, 54, 55 },
                      { 64, 65, 66, 67, 68, 69, 70, 71 },
                      { 80, 81, 82, 83, 84, 85, 86, 87 },
                      { 96, 97, 98, 99, 100, 101, 102, 103 },
                      { 112, 113, 114, 115, 116, 117, 118, 119 },
          };

        /*    private byte[,] decimalNotes = new byte[8, 8]
    {
        { 112, 113, 114, 115, 116, 117, 118, 119 },
        { 96, 97, 98, 99, 100, 101, 102, 103 },
        { 80, 81, 82, 83, 84, 85, 86, 87 },
        { 64, 65, 66, 67, 68, 69, 70, 71 },
        { 48, 49, 50, 51, 52, 53, 54, 55 },
        { 32, 33, 34, 35, 36, 37, 38, 39 },
        { 16, 17, 18, 19, 20, 21, 22, 23 },
        { 0, 1, 2, 3, 4, 5, 6, 7 },        
    };*/

      /*  private byte[,] decimalNotes = new byte[8, 8]
{
    { 119, 118, 117, 116, 115, 114, 113, 112 },
    { 103,102,101, 100, 99, 98, 97, 96 },
    { 87, 86, 85, 84, 83, 82, 81, 80 },
    { 71, 70, 69, 68, 67, 66, 65, 64 },
    { 55, 54, 53, 52, 51, 50, 49, 48 },
    { 39, 38, 37, 36, 35, 34, 33, 32 },
    { 23, 22, 21, 20, 19, 18, 17, 16 },
    { 7, 6, 5, 4, 3, 2, 1, 0 },
};*/

          /*     private byte[,] decimalNotes = new byte[8, 8]
        {
                    { 64, 65, 66, 67, 96, 97, 98, 99 },
                    { 60, 61, 62, 63, 92, 93, 94, 95 },
                    { 56, 57, 58, 59, 88, 89, 90, 91 },
                    { 52, 53, 54, 55, 84, 85, 86, 87 },
                    { 48, 49, 50, 51, 80, 81, 82, 83 },
                    { 44, 45, 46, 47, 76, 77, 78, 79 },
                    { 40, 41, 42, 43, 72, 73, 74, 75 },
                    { 36, 37, 38, 39, 68, 69, 70, 71 },
        };*/

        private Pitch[] rightLEDnotes = new Pitch[] {
            Pitch.GSharp2, Pitch.C0, Pitch.E1, Pitch.GSharp2, Pitch.C4, Pitch.E5, Pitch.GSharp6, Pitch.C8
        };

        public InputDevice targetInput;
        public OutputDevice targetOutput;

        public delegate void LaunchpadKeyEventHandler(object source, LaunchpadKeyEventArgs e);

        public delegate void LaunchpadCCKeyEventHandler(object source, LaunchpadCCKeyEventArgs e);

        /// <summary>
        /// Event Handler when a Launchpad Key is pressed.
        /// </summary>
        public event LaunchpadKeyEventHandler OnLaunchpadKeyPressed;
        public event LaunchpadCCKeyEventHandler OnLaunchpadCCKeyPressed;

        public class LaunchpadCCKeyEventArgs : EventArgs
        {
            private int val;
            private int type;
            public LaunchpadCCKeyEventArgs(int _val, int _type)
            {
                val = _val;
                type = _type;
            }
            public int GetVal()
            {
                return val;
            }
            public string GetButtonType()
            {
                if (type == 0)
                    return "side";
                else if (type == 1)
                    return "top";
                else
                    return "";
            }
        }

        /// <summary>
        /// EventArgs for pressed Launchpad Key
        /// </summary>
        public class LaunchpadKeyEventArgs : EventArgs
        {
            private int x;
            private int y;
            public LaunchpadKeyEventArgs(int _pX, int _pY)
            {
                x = _pX;
                y = _pY;
            }
            public int GetX()
            {
                return x;
            }
            public int GetY()
            {
                return y;
            }
        }

        /// <summary>
        /// Creates a text scroll.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        /// <param name="looping"></param>
        /// <param name="velo"></param>
        public void createTextScroll(string text, int speed, bool looping, int velo)
        {
            byte[] sysexHeader = { 176, 0 };
            byte[] sysexStop = { 0 };
            byte operation = 0;

            byte _velocity = (byte)velo;
            byte _speed = (byte)speed;
            byte _loop = Convert.ToByte(looping);
            byte[] _text = { };

            byte[] finalArgs = { operation, _velocity, _loop, _speed };

            List<byte> charList = new List<byte>();
            foreach(char c in text)
            {
                int unicode = c;
                if (unicode < 128)
                    charList.Add(Convert.ToByte(unicode));
            }
            _text = charList.ToArray();

            byte[] finalBytes = sysexHeader.Concat(finalArgs.Concat(_text.Concat(sysexStop))).ToArray();

            targetOutput.SendSysEx(finalBytes);
        }

        /// <summary>
        /// Stops a looping Text Scroll
        /// </summary>
        public void stopLoopingTextScroll()
        {
            byte[] stop = { 240, 0, 32, 41, 2, 24, 20, 247 };
            targetOutput.SendSysEx(stop);
        }

        //This is a event handler for receiving SysEx messages
        private void sysExAnswer(SysExMessage m)
        {
            byte[] msg = m.Data;
            byte[] stopBytes = { 240, 0, 32, 41, 2, 24, 21, 247 };
        }

        //Event handler for Control Change (top buttons)
        private void controlChange(Midi.ControlChangeMessage msg)
        {
            if (OnLaunchpadCCKeyPressed != null && int.Parse(msg.Control.ToString()) >= 104 && int.Parse(msg.Control.ToString()) <= 111 && msg.Value != 0)
            {
                OnLaunchpadCCKeyPressed(this, new LaunchpadCCKeyEventArgs(int.Parse(msg.Control.ToString()), 1));
            }
        }

        //Event handler for MIDI NOTE ON
        private void midiPress(Midi.NoteOnMessage msg)
        {
            if (OnLaunchpadKeyPressed != null && !rightLEDnotes.Contains(msg.Pitch) && msg.Velocity != 0)
            {
                OnLaunchpadKeyPressed(this, new LaunchpadKeyEventArgs(midiNoteToLed(msg.Pitch)[0], midiNoteToLed(msg.Pitch)[1]));
            }
            else if (OnLaunchpadCCKeyPressed != null && rightLEDnotes.Contains(msg.Pitch) && msg.Velocity != 0)
            {
                OnLaunchpadCCKeyPressed(this, new LaunchpadCCKeyEventArgs(midiNoteToSideLED(msg.Pitch), 0));
            }
        }

        /// <summary>
        /// Converts MIDI note to Side LED
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int midiNoteToSideLED(Pitch p)
        {
            for (int y = 0; y <= 7; y++)
            {
                if (rightLEDnotes[y] == p)
                {
                    return y;
                }
            }
            return 0;
        }

        /// <summary>
        /// Returns the LED coordinates of a MIdi note
        /// </summary>
        /// <param name="p">The Midi Note.</param>
        /// <returns>The X,Y coordinates.</returns>
        public int[] midiNoteToLed(Pitch p)
        {
            for (int x = 0; x <= 7; x++)
            {
                for (int y = 0; y <= 7; y++)
                {
                    if (notes[x,y] == p)
                    {
                        int[] r1 = { x, y };
                        return r1;
                    }
                }
            }
            int[] r2 = { 0, 0 };
            return r2;
        }

        /// <summary>
        /// Returns the equilavent Midi Note to X and Y coordinates.
        /// </summary>
        /// <param name="x">The X coordinate of the LED</param>
        /// <param name="y">The Y coordinate of the LED</param>
        /// <returns>The midi note</returns>
        public Pitch ledToMidiNote(int x, int y)
        {
            return notes[x, y];
        }

        public void clearAllLEDs()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    setLED(x+1, y+1, 0);
                }
            }

            for (int ry = 0; ry < 8; ry++)
            {
                setSideLED(ry, 0);
            }

            for (int tx = 1; tx < 9; tx++)
            {
                setTopLEDs(tx, 0);
            }
        }

        /// <summary>
        /// Fills Top Row LEDs.
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="endX"></param>
        /// <param name="velo"></param>
        public void fillTopLEDs(int startX, int endX, int velo)
        {
            for (int x = 1; x < 9; x++)
            {
                if (x >= startX && x <= endX)
                {
                    setTopLEDs(x, velo);
                }
            }
        }

        /// <summary>
        /// Fills a region of Side LEDs.
        /// </summary>
        /// <param name="startY"></param>
        /// <param name="endY"></param>
        /// <param name="velo"></param>
        public void fillSideLEDs(int startY, int endY, int velo)
        {
            for (int y = 0; y < rightLEDnotes.Length; y++)
            {
                if (y >= startY && y <= endY)
                {
                    setSideLED(y, velo);
                }
            }
        }

        /// <summary>
        /// Creates a rectangular mesh of LEDs.
        /// </summary>
        /// <param name="startX">Start X coordinate</param>
        /// <param name="startY">Start Y coordinate</param>
        /// <param name="endX">End X coordinate</param>
        /// <param name="endY">End Y coordinate</param>
        /// <param name="velo">Painting velocity</param>
        public void fillLEDs(int startX, int startY, int endX, int endY, int velo)
        {
            for (int x = 0; x < notes.Length; x++)
            {
                for (int y = 0; y < notes.Length; y++)
                {
                    if (x >= startX && y >= startY && x <= endX && y <= endY)
                        setLED(x, y, velo);
                }
            }
        }

        /// <summary>
        /// Sets a Top LED of the launchpad
        /// </summary>
        /// <param name="x"></param>
        /// <param name="velo"></param>
        public void setTopLEDs(int x, int velo)
        {
            byte[] data = { 240, 0, 32, 41, 2, 24, 10, Convert.ToByte(103 + x), Convert.ToByte(velo), 247 };
            targetOutput.SendSysEx(data);
        }

        /// <summary>
        /// Sets a Side LED of the Launchpad.
        /// </summary>
        /// <param name="y">The height of the right Side LED.</param>
        /// <param name="velo">Velocity index.</param>
        public void setSideLED(int y, int velo)
        {
            targetOutput.SendNoteOn(Channel.Channel1, rightLEDnotes[y], velo);
        }

        /// <summary>
        /// Sets a LED of the Launchpad.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <param name="velo">The velocity.</param>
        public void setLED(int x, int y, int velo)
        {
            try
            {
                targetOutput.SendNoteOn(Channel.Channel1, notes[y-1, x-1], velo);
            }
            catch (Midi.DeviceException)
            {
                Console.WriteLine("<< LAUNCHPAD.NET >> Midi.DeviceException");
                throw;
            }
        }

        /// <summary>
        /// Returns all connected and installed Launchpads.
        /// </summary>
        /// <returns>Returns LaunchpadDevice array.</returns>
        public LaunchpadDevice[] getConnectedLaunchpads()
        {
            List<LaunchpadDevice> tempDevices = new List<LaunchpadDevice>();

            foreach (InputDevice id in Midi.InputDevice.InstalledDevices)
            {
                foreach (OutputDevice od in Midi.OutputDevice.InstalledDevices)
                {
                    if (id.Name == od.Name)
                    {
                        if (id.Name.ToLower().Contains("launchpad"))
                        {
                            tempDevices.Add(new LaunchpadDevice(id.Name));
                        }
                    }
                }
            }

            return tempDevices.ToArray();
        }

        /// <summary>
        /// Function to connect with a LaunchpadDevice
        /// </summary>
        /// <param name="device">The Launchpad to connect to.</param>
        /// <returns>Returns bool if connection was successful.</returns>
        public bool connect(LaunchpadDevice device)
        {
            foreach(InputDevice id in Midi.InputDevice.InstalledDevices)
            {
                if (id.Name.ToLower() == device._midiName.ToLower())
                {
                    targetInput = id;
                    id.Open();
                    targetInput.NoteOn += new InputDevice.NoteOnHandler(midiPress);
                    targetInput.ControlChange += new InputDevice.ControlChangeHandler(controlChange);
                    targetInput.StartReceiving(null);
                }
            }
            foreach (OutputDevice od in Midi.OutputDevice.InstalledDevices)
            {
                if (od.Name.ToLower() == device._midiName.ToLower())
                {
                    targetOutput = od;
                    od.Open();
                }
            }

            return true; // targetInput.IsOpen && targetOutput.IsOpen;
        }

        /// <summary>
        /// Disconnects a given LaunchpadDevice
        /// </summary>
        /// <param name="device">The Launchpad to disconnect.</param>
        /// <returns>Returns bool if disconnection was successful.</returns>
        public bool disconnect(LaunchpadDevice device)
        {
            if (targetInput.IsOpen && targetOutput.IsOpen)
            {
                targetInput.StopReceiving();
                targetInput.Close();
                targetOutput.Close();
            }
            return !targetInput.IsOpen && !targetOutput.IsOpen;
        }

        public class LaunchpadDevice
        {
            public string _midiName;
            //public int _midiDeviceId;

            public LaunchpadDevice(string name)
            {
                _midiName = name;
            }
        }
    }
}
