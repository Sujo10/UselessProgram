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
using System.Windows.Shapes;
using System.Media;

namespace SquirrelTester
{

    public partial class ChooserWindow : Window
    {

        private SoundPlayer _soundPlayer;

        public ChooserWindow()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Scary.wav");
        }

        private void ScaryButton_OnClick(object sender, RoutedEventArgs e)
        {
            ScaryWindow scaryWindow = new ScaryWindow();
            scaryWindow.Show();
            _soundPlayer.Play();
        }

        private void ConfusingButton_OnClick(object sender, RoutedEventArgs e)
        {
            ConfusingWindow confusingWindow = new ConfusingWindow();
            confusingWindow.Show();
            _soundPlayer.Play();
        }
    }
}
