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
using MahApps.Metro.Controls;
using LaunchpadNET;
using System.Windows.Media.Effects;
using System.Windows.Media.Animation;

namespace launchpad_audio_vis
{
    public partial class MainWindow : MetroWindow
    {
        public AudioAnalyzer analyzer;
        public BlurEffect visBlurEffect;
        public DoubleAnimation visBlurEffectAnim;

        public MainWindow()
        {
            InitializeComponent();
            analyzer = new AudioAnalyzer(this);

            visBlurEffect = new BlurEffect();
            visBlurEffect.RenderingBias = RenderingBias.Quality;
            visBlurEffect.KernelType = KernelType.Gaussian;
            visBlurEffect.Radius = 0;

            visBlurEffectAnim = new DoubleAnimation();
            visBlurEffectAnim.From = 0;
            visBlurEffectAnim.To = 20;
            visBlurEffectAnim.Duration = new Duration(TimeSpan.FromSeconds(0.2));

            visualizer.Effect = visBlurEffect;
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            analyzer.Free();
            analyzer.DisconnectLaunchpad();
        }

        private void Devices_Clicked(object sender, RoutedEventArgs e)
        {
            
        }

        private void launchpadCombo_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Select");
            foreach (Interface.LaunchpadDevice d in analyzer.GetInterface().getConnectedLaunchpads())
            {
                data.Add(d._midiName);
            }

            var cb = sender as ComboBox;
            cb.SelectionChanged -= launchpadCombo_SelectionChanged;
            cb.ItemsSource = data;
            cb.SelectedIndex = 0;
            cb.SelectionChanged += launchpadCombo_SelectionChanged;
        }

        private void launchpadCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb.SelectedIndex != 0)
            {
                if (analyzer.GetCurrentLaunchpad() != null)
                {
                    if (analyzer.GetCurrentLaunchpad()._midiName != cb.SelectedItem.ToString())
                    {
                        analyzer.DisconnectLaunchpad();
                        analyzer.SetCurrentLaunchpad(cb.SelectedItem.ToString());
                    }
                }
                else
                {
                    analyzer.SetCurrentLaunchpad(cb.SelectedItem.ToString());
                }
            }
        }

        private void enableVis_Checked(object sender, RoutedEventArgs e)
        {
            analyzer.Enable = true;
        }

        private void enableVis_uncheck(object sender, RoutedEventArgs e)
        {
            analyzer.Enable = false;
        }

        private void enableSoftwareVis_Checked(object sender, RoutedEventArgs e)
        {
            analyzer.EnableSoftwareVis(true);
            visBlurEffectAnim.To = 0;
            visBlurEffectAnim.From = 20;
            visualizer.Effect.BeginAnimation(BlurEffect.RadiusProperty, visBlurEffectAnim);
            visBlurEffectAnim.To = 20;
            visBlurEffectAnim.From = 0;
        }

        private void enableSoftwareVis_Unchecked(object sender, RoutedEventArgs e)
        {
            analyzer.EnableSoftwareVis(false);

            visualizer.Effect.BeginAnimation(BlurEffect.RadiusProperty, visBlurEffectAnim);
        }
    }

}
