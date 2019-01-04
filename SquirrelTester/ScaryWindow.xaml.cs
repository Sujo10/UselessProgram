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

namespace SquirrelTester
{
    /// <summary>
    /// Interaction logic for BaraccoBarner.xaml
    /// </summary>
    public partial class ScaryWindow : Window
    {
        public ScaryWindow()
        {
            InitializeComponent();
        }

        private void CloseBaracButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
