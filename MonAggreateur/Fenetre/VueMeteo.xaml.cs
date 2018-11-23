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
    /// Logique d'interaction pour VueMeteo.xaml
    /// </summary>
    public partial class VueMeteo : Window
    {
        protected Meteo meteo = null;
        protected Controleur controleur = null;

        public void activerControleur(Controleur controleurRecu)
        {
            this.controleur = controleurRecu;
        }

        public VueMeteo()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Console.WriteLine("VueMeteo");
            InitializeComponent();
            this.meteo = new Meteo();
        }

        public void afficherMeteo(List<Meteo> listeMeteos)
        {
            this.listeMeteo.Text = "";
            foreach (Meteo meteo in listeMeteos)
            {
                Console.WriteLine(meteo.titre);
                this.listeMeteo.Text += meteo.titre + "\n";
            }
            Console.WriteLine(listeMeteos);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nouvelle_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonNouvelle();
        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("tu es deja dans Meteo");
        }

        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonPokemon();
        }

        private void Cryptomonaie_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonCryptoMonaie();
        }

        private void Slack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
