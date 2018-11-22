using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MonAggreateur
{
    class NavigationFenetre
    {
        public enum ACTION_NAVIGUER { CRYPTOMONAIE, METEO, NOUVELLE, POKEMON, SLACK }

        private Window premiereVue = null;
        protected Window vueCourant = null;

        private NavigationFenetre()
        {

        }

        private static NavigationFenetre navigateur = null;

        public static NavigationFenetre getInstance()
        {
            if (null == navigateur) navigateur = new NavigationFenetre();
            return navigateur;
        }

        public void enregistrerPremiereVue(Window vue)
        {
            this.premiereVue = vue;
            this.vueCourant = this.premiereVue;   
        }

        protected VueCryptoMonaie vueCryptoMonaie = null;

        public void naviguerVersCryptoMonaie()
        {
            Console.WriteLine("naviguerVersCryptoMonaie()");
            if (this.vueCryptoMonaie == null) this.vueCryptoMonaie = new VueCryptoMonaie();
            this.vueCryptoMonaie.Show();
            this.vueCourant.Hide();
            this.vueCourant = this.vueCryptoMonaie;
        }
    }
}
