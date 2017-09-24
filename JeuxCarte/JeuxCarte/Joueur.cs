using System;
using System.Collections.Generic;
using System.Text;

namespace JeuxCarte
{
    class Joueur
    {
        private String Nom = "";
        private Main Main = new Main();

        //Constructeur
        public Joueur(string Nom)
        {
            this.Nom = Nom;
        }

        //Getter et setter
        public String NomJoueur
        {
            get { return Nom; }
            set { value = Nom; }
        }

        public Main MainJoueur
        {
            get { return Main; }
        }

        //Méthode


    }
}
