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

namespace MonAggreateur.Fenetre
{
    /// <summary>
    /// Logique d'interaction pour VueSlack.xaml
    /// </summary>
    public partial class VueSlack : Window
    {
        protected Controleur controleur = null;

        public void activerControleur(Controleur controleurRecu)
        {
            this.controleur = controleurRecu;
        }
        public VueSlack()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Console.WriteLine("VueSlack");
            InitializeComponent();

        }

        public void afficherSlack()
        {
            //string listeMessages = listerMessagesParSalon("");
        }

        private void Button_Click(object sender, RoutedEventArgs e) // Accueil
        {
            this.controleur.notifierBoutonAccueil();
        }

        private void Nouvelle_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonNouvelle();
        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonMeteo();
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
           // this.controleur.
        }
    }
}
