using System;
using System.ComponentModel;
using System.Media;
using System.Net.Mime;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using Squirrel;


namespace SquirrelTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SoundPlayer _soundPlayer;
        int count = 0;
        //string urls = "https://www.youtube.com/watch?v=q6-ZGAGcJrk";

        public MainWindow()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Scary.wav");
            CheckForUpdates().ConfigureAwait(true);
            //System.Diagnostics.Process.Start(urls);
        }

        private async Task CheckForUpdates()
        {
            using (var updateManager = new UpdateManager(@"U:\DevDSL\SquirrelAlpha\TestProgram"))
            {
                await updateManager.UpdateApp();
            }
        }

        private void InfoButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbri = MessageBox.Show("This is the most useless Program in the whole World", "About", MessageBoxButton.OK, MessageBoxImage.Information);
            {
                MessageBox.Show("Seriously... It's f*cking useless", "Seriously", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        protected void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show("Do you really want to close this application?", "Close it?", MessageBoxButton.YesNo);
            if (mbr == MessageBoxResult.Yes)
            {
                MessageBoxResult mbr1 = MessageBox.Show("Are you sure?", "Sure?", MessageBoxButton.YesNo);
                if (mbr1 == MessageBoxResult.Yes)
                {
                    MessageBoxResult mbr2 = MessageBox.Show("Are you really sure?", "Really Sure?", MessageBoxButton.YesNo);
                    if (mbr2 == MessageBoxResult.Yes)
                    {
                        MessageBoxResult mbr3 = MessageBox.Show("OK!", "OK!", MessageBoxButton.OK);
                        {
                            _soundPlayer.Stop();
                            App.Current.Shutdown();
                        }
                    }
                }
            }
        }

        private void MysteriousButton_OnClick(object sender, RoutedEventArgs e)
        {
            ChooserWindow chooserWindow = new ChooserWindow();
            chooserWindow.Show();

            count++;
            if (count != 0)
            {
                _textBlock.Text = "Where is the Mysterious Button?";
                MysteriousButton.Visibility = Visibility.Hidden;
            }
        }
    }
}
