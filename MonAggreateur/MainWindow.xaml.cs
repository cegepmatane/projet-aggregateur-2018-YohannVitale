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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonAggreateur
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NouvelleDAO nouvelleDAO = new NouvelleDAO();
        MeteoDAO meteoDAO = new MeteoDAO();
        public MainWindow()
        {
            InitializeComponent();
           // nouvelle();
           // meteo();
            
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
        private void Nouvelle_Click(object sender, RoutedEventArgs e)
        {
            nouvelle();
        }
       private void Button_Click(object sender, RoutedEventArgs e) // acceuil
        {

        }
    }
}
