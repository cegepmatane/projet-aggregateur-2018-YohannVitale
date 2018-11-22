using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAggreateur
{
    public class Controleur
    {
        NouvelleDAO nouvelleDAO = new NouvelleDAO();
        MeteoDAO meteoDAO = new MeteoDAO();
        PokemonDAO pokemonDAO = new PokemonDAO();
        CryptomonaieDAO cryptomonaieDAO = new CryptomonaieDAO();
        SlackDAO slackDAO = new SlackDAO();
        VueAccueil fenetrePrincipale = null;

        public void activerFenetrePrincipale(VueAccueil fenetreRecue)
        {
            this.fenetrePrincipale = fenetreRecue;
        }

        public void nouvelle()
        {
            string rssJournal = "https://www.journaldemontreal.com/rss.xml";

            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelle(rssJournal);

            foreach (Nouvelle nouvelle in listeNouvelles)
            {
                Console.WriteLine(nouvelle.titre);
                Console.WriteLine(nouvelle.pubDate);
                Console.WriteLine(nouvelle.description);
            }
            Console.WriteLine(listeNouvelles);
        }

        public void notifierBoutonMeteo()
        {

        }

        protected VueCryptoMonaie vueCryptoMonaie = null;
        public void notifierBoutonCryptoMonaie()
        {

            Console.WriteLine("notifierBoutonCryptoMonaie");
            this.vueCryptoMonaie = new VueCryptoMonaie();
            this.vueCryptoMonaie.Show();
            List<CryptoMonaie> listeMonnaies = cryptomonaieDAO.listerMonnaies();
            foreach (CryptoMonaie monnaie in listeMonnaies)
            {
                Console.WriteLine("Programme principal : " + monnaie.nom);
            }

        }

        //Focntion sans bouton
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
                Console.WriteLine("Pokemon du programme principal : " + pokemon.nom);
            }
        }

       /* public void cryptomonaie()
        {
            List<CryptoMonaie> listeMonnaies = cryptomonaieDAO.listerMonnaies();
            foreach (CryptoMonaie monnaie in listeMonnaies)
            {
                Console.WriteLine("Programme principal : " + monnaie.nom);
            }
        }*/
        public void slack()
        {
            string listeMessages = slackDAO.listerMessagesParSalon("");
        }


    }
}
