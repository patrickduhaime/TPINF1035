﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JeuCarte
{
    class Joueur
    {
        private String Nom = "";
        private String Prenom = "";
        private Main Main;

        //Constructeur
        public Joueur(string Prenom, string Nom)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            Main = new Main();
        }

        //Getter et setter
        public String NomJoueur
        {
            get { return Nom; }
            set { value = Nom; }
        }

        public String PrenomJoueur
        {
            get { return Prenom; }
            set { value = Prenom; }
        }

        public Main MainJoueur
        {
            get { return Main; }
        }

        //Méthode
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
