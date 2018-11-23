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

        protected Fenetre.VueNouvelle vueNouvelle = null;
        public void notifierBoutonNouvelle()
        {
            Console.WriteLine("notifierBoutonNouvelle");
            this.vueNouvelle = new Fenetre.VueNouvelle();
            this.vueNouvelle.Show();
            string rssJournal = "https://www.journaldemontreal.com/rss.xml";
            List<Nouvelle> listeNouvelles = nouvelleDAO.listerNouvelle(rssJournal);
            this.vueNouvelle.afficherNouvelle(listeNouvelles);

        }
        protected VueMeteo vueMeteo = null;
        public void notifierBoutonMeteo()
        {
            Console.WriteLine("notifierBoutonMeteo");
            this.vueMeteo = new VueMeteo();
            this.vueMeteo.Show();
            string rssMeteoQuebec = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
            List<Meteo> listeMeteos = meteoDAO.listerMeteo(rssMeteoQuebec);
            this.vueMeteo.afficherMeteo(listeMeteos);

        }

        protected VueCryptoMonaie vueCryptoMonaie = null;
        public void notifierBoutonCryptoMonaie()
        {

            Console.WriteLine("notifierBoutonCryptoMonaie");
            this.vueCryptoMonaie = new VueCryptoMonaie();
            this.vueCryptoMonaie.Show();
            List<CryptoMonaie> listeMonnaies = cryptomonaieDAO.listerMonnaies();
            this.vueCryptoMonaie.afficherCryptoMonaie(listeMonnaies);


        }

        protected Fenetre.VuePokemon vuePokemon = null;
        public void notifierBoutonPokemon()
        {
            Console.WriteLine("notifierBoutonPokemon");
            this.vuePokemon = new Fenetre.VuePokemon();
            this.vuePokemon.Show();
            List<Pokemon> listePokemons = pokemonDAO.listerPokemon();
            this.vuePokemon.afficherPokemon(listePokemons);
        }

        /*public void nouvelle()
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
        }*/



        /*protected VueAccueil vueAccueil = null;
        public void notifierBoutonAccueil()
        {
            Console.WriteLine("notifierBoutonAccueil");
            this.vueAccueil = new VueAccueil();
            this.vueAccueil.Show();
        }*/

        //Focntion sans bouton
        /*public void meteo()
        {
            string rssMeteoQuebec = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
            List<Meteo> listeMeteos = meteoDAO.listerMeteo(rssMeteoQuebec);
            foreach (Meteo meteo in listeMeteos)
            {
                Console.WriteLine(meteo.titre);
            }
            Console.WriteLine(listeMeteos);
        }*/

       /* public void pokemon()
        {
            List<Pokemon> listePokemon = pokemonDAO.listerPokemon();
            foreach (Pokemon pokemon in listePokemon)
            {
                Console.WriteLine("Pokemon du programme principal : " + pokemon.nom);
            }
        }*/

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
