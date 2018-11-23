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
    /// Logique d'interaction pour VueNouvelle.xaml
    /// </summary>
    public partial class VueNouvelle : Window
    {
        protected Nouvelle nouvelle = null;
        protected Controleur controleur = null;

        public void activerControleur(Controleur controleurRecu)
        {
            this.controleur = controleurRecu;
        }

        public VueNouvelle()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Console.WriteLine("VueNouvelle");
            InitializeComponent();
            this.nouvelle = new Nouvelle();
        }

        public void afficherNouvelle(List<Nouvelle> listeNouvelles)
        {
            this.listeTitreNouvelle.Text = "";
            foreach (Nouvelle nouvelle in listeNouvelles)
            {
                //Console.WriteLine(nouvelle.titre);
                this.listeTitreNouvelle.Text += nouvelle.titre +'\n';
                //Console.WriteLine(nouvelle.pubDate);
                this.listeTitreNouvelle.Text += nouvelle.pubDate + '\n';
                //Console.WriteLine(nouvelle.description);
                this.listeTitreNouvelle.Text += nouvelle.description + '\n';
            }
            //Console.WriteLine(listeNouvelles);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nouvelle_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Tu es deja dans Nouvelle");
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

        }
    }
}
