using System;
using System.Collections.Generic;
using System.Windows;




namespace MonAggreateur 
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class VueAccueil : Window
    {
        NouvelleDAO nouvelleDAO = new NouvelleDAO();
        MeteoDAO meteoDAO = new MeteoDAO();
        PokemonDAO pokemonDAO = new PokemonDAO();
        CryptomonaieDAO cryptomonaieDAO = new CryptomonaieDAO();
        SlackDAO slackDAO = new SlackDAO();
        protected Controleur controleur = null;
        public VueAccueil(Controleur controleur)
        {
            this.controleur = controleur;

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.controleur.activerFenetrePrincipale(this);

        }

        public VueAccueil()
        {
            this.controleur = new Controleur();

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            this.controleur.activerFenetrePrincipale(this);

        }

        private void Nouvelle_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonNouvelle();
            //nouvelle();

        }
        private void Button_Click(object sender, RoutedEventArgs e) // acceuil
        {
            
            //this.controleur.notifierBoutonAccueil();
        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonMeteo();
            //meteo();
        }

        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonPokemon();
            //pokemon();
        }

        private void Cryptomonaie_Click(object sender, RoutedEventArgs e)
        {
            this.controleur.notifierBoutonCryptoMonaie();
            //cryptomonaie();
        }

        private void Slack_Click(object sender, RoutedEventArgs e)
        {
           // slack();
        }
    }
}
