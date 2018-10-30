using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace MonAggreateur
{
    class NouvelleDAO
    {
        //public List<Nouvelle> listerNouvelle(string rss);
        public List<Nouvelle> listerNouvelle(string rss)
        {
            List<Nouvelle> listeNouvelles = new List<Nouvelle>();

            //Console.WriteLine("RssDAO.listerNouvelle(" + rss + ")");
            WebRequest requeteNouvelle = WebRequest.Create(rss);
            WebResponse reponse = requeteNouvelle.GetResponse();
            StreamReader lecteurNouvelle = new StreamReader(reponse.GetResponseStream());
            string xmlNouvelle = lecteurNouvelle.ReadToEnd();

            XElement nouvellesXML = XElement.Parse(xmlNouvelle);


            foreach (XElement nouvelleXML in nouvellesXML.Elements())
            {
                // Console.WriteLine(nouvelleXML.ToString());
                //XDocument nouvelleDoc = nouvelleXML.Document;
                XmlReader lireNouvelle = nouvelleXML.CreateReader();
                lireNouvelle.MoveToContent();
                lireNouvelle.ReadToDescendant("title");

                string titre = lireNouvelle.ReadInnerXml();
                Console.WriteLine(titre);

                /* lireNouvelle.ReadToFollowing("link");
                 string lien = lireNouvelle.MoveToAttribute("href").ToString();
                 Console.WriteLine(lien);*/

                lireNouvelle.ReadToFollowing("published");
                string publication = lireNouvelle.ReadInnerXml();
                Console.WriteLine(publication);

                /*lireNouvelle.ReadToFollowing("category");
                string categorie = lireNouvelle.MoveToAttribute("term").ToString();
                Console.WriteLine(categorie);*/

                lireNouvelle.ReadToFollowing("summary");
                string resume = lireNouvelle.ReadInnerXml();
                Console.WriteLine(resume);

                Nouvelle nouvelle = new Nouvelle();
                nouvelle.titre = titre;
                //nouvelle.lien = lien;
                nouvelle.resume = resume;
                //nouvelle.categorie = categorie;

                listeNouvelles.Add(nouvelle);
            }


            return listeNouvelles;
        }
    }
}
