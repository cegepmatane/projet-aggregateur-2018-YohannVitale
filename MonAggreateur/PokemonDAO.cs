﻿using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace MonAggreateur
{
    class PokemonDAO
    {
        public List<Pokemon> listerPokemon()
        {
            Console.WriteLine("PokemonDAO.listerPokemon()");

            List<Pokemon> listePokemon = new List<Pokemon>();

            string url = "http://pokeapi.co/api/v2/pokemon";
            HttpWebRequest requeteListePokemon = (HttpWebRequest)WebRequest.Create(url);
            requeteListePokemon.Method = "GET";
            requeteListePokemon.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
            WebResponse reponseListePokemon = requeteListePokemon.GetResponse();
            StreamReader lecteurListePokemon = new StreamReader(reponseListePokemon.GetResponseStream());
            string json = lecteurListePokemon.ReadToEnd();
            Console.WriteLine(json);


            JavaScriptSerializer parseur = new JavaScriptSerializer();
            dynamic objet = parseur.Deserialize<dynamic>(json);
            string nombre = objet["count"].ToString();

            dynamic[] listePokemonDynamiques = objet["results"];
            int tour = 0;
            foreach (dynamic pokemonDynamique in listePokemonDynamiques)
            {
                if (tour > 10)
                    break;
                Pokemon pokemon = new Pokemon();
                pokemon.nom = pokemonDynamique["name"].ToString();
                string source = pokemonDynamique["url"].ToString();
                Console.WriteLine(pokemon.nom + " - " + source);
                listePokemon.Add(pokemon);
                tour++;
            }

            Console.WriteLine(nombre + " pokemons recus");
            return listePokemon;
        }
    }
}

