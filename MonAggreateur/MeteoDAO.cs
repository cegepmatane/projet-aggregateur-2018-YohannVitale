using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace MonAggreateur
{
    class MeteoDAO
    {
        public List<Meteo> listerMeteo()
        {
            string rss = "http://meteo.gc.ca/rss/city/qc-133_f.xml";
            List<Meteo> listeMeteos = new List<Meteo>();

            //Console.WriteLine("RssDAO.listerMeteo(" + rss + ")");
            WebRequest requeteMeteo = WebRequest.Create(rss);
            WebResponse reponse = requeteMeteo.GetResponse();
            StreamReader lecteurMeteo = new StreamReader(reponse.GetResponseStream());
            string xmlMeteo = lecteurMeteo.ReadToEnd();

            XElement MeteosXML = XElement.Parse(xmlMeteo);


            foreach (XElement MeteoXML in MeteosXML.Elements())
            {
                XmlReader lireMeteo = MeteoXML.CreateReader();
                lireMeteo.MoveToContent();
                lireMeteo.ReadToDescendant("title");

                string titre = lireMeteo.ReadInnerXml();
                Console.WriteLine(titre);


                lireMeteo.ReadToFollowing("published");
                string publication = lireMeteo.ReadInnerXml();
                Console.WriteLine(publication);


                lireMeteo.ReadToFollowing("summary");
                string resume = lireMeteo.ReadInnerXml();
                Console.WriteLine(resume);

                Meteo Meteo = new Meteo();
                Meteo.titre = titre;
                Meteo.resume = resume;

                listeMeteos.Add(Meteo);
            }


            return listeMeteos;
        }
    }
}

