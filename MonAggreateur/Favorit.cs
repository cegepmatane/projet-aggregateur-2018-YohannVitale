using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAggreateur
{
    public class Favorit
    {
        protected bool prive;
        public void cacher() { this.prive = false; }
        public void publier() { this.prive = true; }  
        public bool estPrive() { return this.prive; }


        protected string titre;
        public void setTitre(string titreRecu)
        {
            this.titre = titreRecu;
        }

        public string getTitre()
        {
            return this.titre;
        }

        protected string motsClef; 
        public void setMotsClef(string motsClefRecu)
        {
            this.motsClef = motsClefRecu;
        }
        public string getMotsClef()
        {
            return this.motsClef;
        }


        protected string description;
        public void setDescription(string descriptionRecu)
        {
            this.description = descriptionRecu;
        }
        public string getDescription()
        {
            return this.description;
        }


        protected string couleur;
        public void setCouleur(string couleurRecu)
        {
            this.couleur = couleurRecu;
        }
        public string getCouleur()
        {
            return this.couleur;
        }

        public Favorit(string titre)
        {
            this.titre = titre;
        }


        public Favorit seraPrive()
        {
            this.prive = true;
            return this;
        }
        public Favorit seraPublic()
        {
            this.prive = false;
            return this;
        }

        public Favorit avecMotsClef(string motsClef)
        {
            this.motsClef = motsClef;
            return this;
        }

        public Favorit avecDescription(string description)
        {
            this.description = description;
            return this;
        }

        public Favorit avecCouleur(string couleur)
        {
            this.couleur = couleur;
            return this;
        }






    }


}
