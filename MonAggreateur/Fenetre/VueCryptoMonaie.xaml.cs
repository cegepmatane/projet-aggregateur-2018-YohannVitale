using System;
using System.Collections.Generic;
using System.Windows;

namespace MonAggreateur
{
    /// <summary>
    /// Logique d'interaction pour VueCryptoMonaie.xaml
    /// </summary>
    public partial class VueCryptoMonaie : Window
    {
        protected CryptoMonaie cryptoMonaie = null;
        protected Controleur controleur = null;

        public void activerControleur(Controleur controleurRecu)
        {
            this.controleur = controleurRecu;
        }
        public VueCryptoMonaie()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Console.WriteLine("VueCryptoMonaie");
            InitializeComponent();
            this.cryptoMonaie = new CryptoMonaie();
        }

        public void afficherCryptoMonaie(List<CryptoMonaie> listeMonnaies)
        {
            this.listeCryptoMonaie.Text = "";
            foreach (CryptoMonaie monnaie in listeMonnaies)
            {
                // Console.WriteLine("Programme vueCyrptomonaie : " + monnaie.nom);
                this.listeCryptoMonaie.Text += monnaie.nom + "\n";

            }
        }

        
        private void Nouvelle_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonNouvelle();
        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonMeteo();
        }

        private void Cryptomonaie_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("tu es deja dans cryptomonaie");
        }

        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonPokemon();
        }

        private void Slack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)//Accueil
        {
           //this.controleur.notifierBoutonAccueil();
        }
    }
}
