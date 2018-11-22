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

namespace MonAggreateur
{
    /// <summary>
    /// Logique d'interaction pour VueCryptoMonaie.xaml
    /// </summary>
    public partial class VueCryptoMonaie : Window
    {
        protected CryptoMonaie cryptoMonaie = null;
        public VueCryptoMonaie()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Console.WriteLine("VueCryptoMonaie");
            InitializeComponent();
            this.cryptoMonaie = new CryptoMonaie();
        }

        private void Nouvelle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cryptomonaie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Slack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
