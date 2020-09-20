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

namespace AquadraatCyclingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateNewPlay_Click(object sender, RoutedEventArgs e)
        {
            KoersAanmakenWindow AanmaakVenster = new KoersAanmakenWindow();
            //AanmaakVenster.state = 0;
            AanmaakVenster.Top = this.Top;
            AanmaakVenster.Left = this.Left;
            AanmaakVenster.Show();
            this.Close();
        }

        private void btnSavedPlays_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAutoPlay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCredits_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
