using System;
using System.Collections.Generic;
using System.Windows;


namespace MonAggreateur.Fenetre
{
    /// <summary>
    /// Logique d'interaction pour VuePokemon.xaml
    /// </summary>
    public partial class VuePokemon : Window
    {
        protected Pokemon pokemon = null;
        protected Controleur controleur = null;

        public void activerControleur(Controleur controleurRecu)
        {
            this.controleur = controleurRecu;
        }

        public VuePokemon()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Console.WriteLine("VuePokemon");
            InitializeComponent();
            this.pokemon = new Pokemon();
        }

        public void afficherPokemon(List<Pokemon> listePokemons)
        {
            this.listeNomPokemon.Text = "";
            foreach (Pokemon pokemon in listePokemons)
            {
                //Console.WriteLine(pokemon.nom);
                this.listeNomPokemon.Text += pokemon.nom + "\n";
            }
            //Console.WriteLine(listePokemons);
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
            Console.WriteLine("tu es deja dans pokemon");
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
