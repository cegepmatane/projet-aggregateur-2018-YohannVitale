using System;
using System.Collections.Generic;
using System.Windows;




namespace MonAggreateur 
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NouvelleDAO nouvelleDAO = new NouvelleDAO();
        MeteoDAO meteoDAO = new MeteoDAO();
        PokemonDAO pokemonDAO = new PokemonDAO();
        CryptomonaieDAO cryptomonaieDAO = new CryptomonaieDAO();
        SlackDAO slackDAO = new SlackDAO();
        public MainWindow()
        {
            InitializeComponent();

            
        }

        //RSS JOURNAL
        public void nouvelle()
        {
            string rssJournal = "https://www.journaldemontreal.com/rss.xml";

            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelle(rssJournal);

            foreach(Nouvelle nouvelle in listeNouvelles)
            {
                Console.WriteLine(nouvelle.titre);
                Console.WriteLine(nouvelle.pubDate);
                Console.WriteLine(nouvelle.description);
            }
            Console.WriteLine(listeNouvelles);
        }

        public void meteo()
        {
            string rssMeteoQuebec = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
            List<Meteo> listeMeteos = meteoDAO.listerMeteo(rssMeteoQuebec);
            foreach (Meteo meteo in listeMeteos)
            {
                Console.WriteLine(meteo.titre);
            }
            Console.WriteLine(listeMeteos);
        }

        public void pokemon()
        {
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();
            foreach (Pokemon pokemon in listePokemon)
            {
                Console.WriteLine("Pokemon : " + pokemon.nom);
            }
        }

        public void cryptomonaie()
        {
            List<CryptoMonaie> listeMonnaies = cryptomonaieDAO.listerMonnaies();
            foreach (CryptoMonaie monnaie in listeMonnaies)
            {
                Console.WriteLine("Monaie : " + monnaie.nom);
            }
        }

        public void slack()
        {
            string listeMessages = slackDAO.listerMessagesParSalon("");
        }

        private void Nouvelle_Click(object sender, RoutedEventArgs e)
        {
            nouvelle();

        }
       private void Button_Click(object sender, RoutedEventArgs e) // acceuil
        {
           
        }

        private void Meteo_Click(object sender, RoutedEventArgs e)
        {
            meteo();
        }

        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            pokemon();
        }

        private void Cryptomonaie_Click(object sender, RoutedEventArgs e)
        {
            cryptomonaie();
        }

        private void Slack_Click(object sender, RoutedEventArgs e)
        {
            slack();
        }
    }
}
