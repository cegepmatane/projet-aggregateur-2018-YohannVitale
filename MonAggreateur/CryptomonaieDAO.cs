using System;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace MonAggreateur
{
    class CryptomonaieDAO
    {
        public List<CryptoMonaie> listerMonnaies() // les monnaies sont incompletes, sans leur valeur actuelle
        {
            
            Console.WriteLine("cryptomonaieDAO.listerMonnaies()");
            string url = "https://www.cryptocompare.com/api/data/coinlist/";
            HttpWebRequest requeteListeMonnaies = (HttpWebRequest)WebRequest.Create(url);
            WebResponse reponse = requeteListeMonnaies.GetResponse();
            StreamReader lecteurListeMonnaies = new StreamReader(reponse.GetResponseStream());
            string json = lecteurListeMonnaies.ReadToEnd();
            //Console.WriteLine(json);

            JavaScriptSerializer parseur = new JavaScriptSerializer();
            dynamic objet = parseur.Deserialize<dynamic>(json);
            var lesMonnaies = objet["Data"];

            List<CryptoMonaie> listecryptomonaie = new List<CryptoMonaie>();
            int tour = 0;
            foreach (dynamic itemMonnaie in lesMonnaies)
            {
                if (tour > 10)
                    break;
                //Console.WriteLine(itemMonnaie.ToString());
                // Donne : [AXIS, System.Collections.Generic.Dictionary`2[System.String, System.Object]]
                // Même si on a [truc1, truc2] c'est pas un tableau, c'est un cle => valeur, acces avec .Key & .Value
                var monnaie = itemMonnaie.Value;
                var symbole = monnaie["Symbol"];
                var nom = monnaie["CoinName"];
                var algorithme = monnaie["Algorithm"];
                var nombre = monnaie["TotalCoinSupply"];
                // var illustration = monnaie["ImageUrl"]; KeyNotFoundException
                Console.WriteLine("Monnaie " + symbole + " : " + nom + "(" + nombre + ")");

                // TODO optimiser
                CryptoMonaie cryptomonaie = new CryptoMonaie();
                cryptomonaie.symbole = symbole;
                cryptomonaie.nom = nom;
                cryptomonaie.algorithme = algorithme;
                cryptomonaie.nombre = nombre;
                listecryptomonaie.Add(cryptomonaie);
                listecryptomonaie.Add(cryptomonaie);
                tour++;
            }

            return listecryptomonaie;
        }

        public CryptoMonaie detaillerMonnaie()
        {
            CryptoMonaie cryptomonaie = new CryptoMonaie();



            return cryptomonaie;
        }
    }
}
