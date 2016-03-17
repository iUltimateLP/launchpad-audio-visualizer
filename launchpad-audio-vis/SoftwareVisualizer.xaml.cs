using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace launchpad_audio_vis
{
    /// <summary>
    /// Interaktionslogik für SoftwareVisualizer.xaml
    /// </summary>
    public partial class SoftwareVisualizer : UserControl
    {
        private AudioAnalyzer _inst;

        public SoftwareVisualizer()
        {
            InitializeComponent();
        }

        public void SetInstance(AudioAnalyzer inst)
        {
            _inst = inst;
        }

        public void SetData(List<byte> data)
        {
            if (data.Count < 8) return;
            Bar01.Value = data[0];
            Bar02.Value = data[1];
            Bar03.Value = data[2];
            Bar04.Value = data[3];
            Bar05.Value = data[4];
            Bar06.Value = data[5];
            Bar07.Value = data[6];
            Bar08.Value = data[7];
        }
    }
}
