using System;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;

namespace MonAggreateur
{
    class SlackDAO
    {
        public string listerSalons()
        {
            Console.WriteLine("SalonDAO.listerSalons()");
            string json = "";

            string url = "https://slack.com/api/channels.list?token=xoxp-473953774023-473376698226-473681655141-c1f0e28aa268cc2a8f586f80c34330ff&pretty=1";
            WebRequest requetesSalons = WebRequest.Create(url);
            WebResponse reponse = requetesSalons.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
            json = lecteur.ReadToEnd();

            JavaScriptSerializer parseur = new JavaScriptSerializer();
            dynamic objet = parseur.Deserialize<dynamic>(json);
            var lesSalons = objet["channels"];
            foreach (dynamic salon in lesSalons)
            {
                var id = salon["id"];
                var nom = salon["name"];
                Console.WriteLine(id + " : " + nom);
            }

            return json;
        }

        public string listerMessagesParSalon(string salon)
        {
            Console.WriteLine("SalonDAO.listerMessagesParSalon()");
            string json = "";

            string url = "";//mettre le tokken
            WebRequest requetesMessages = WebRequest.Create(url);
            WebResponse reponse = requetesMessages.GetResponse();
            StreamReader lecteur = new StreamReader(reponse.GetResponseStream());
            json = lecteur.ReadToEnd();

            JavaScriptSerializer parseur = new JavaScriptSerializer();
            dynamic objet = parseur.Deserialize<dynamic>(json);
            var lesMessages = objet["messages"];
            foreach (dynamic message in lesMessages)
            {
                var type = message["type"];
                var texte = message["text"];
                Console.WriteLine(type + " : " + texte);
            }

            return json;
        }

    }
}

