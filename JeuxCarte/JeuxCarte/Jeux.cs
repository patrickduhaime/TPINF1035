using System;
using System.Collections.Generic;
using System.Text;

namespace JeuxCarte
{
    class Jeux
    {
        //Déclartation des variables privées.
        private List<Carte> JeuxdeCartes = new List<Carte>();
        private List<Carte> Pile = new List<Carte>();
        private List<Carte> Pioche = new List<Carte>();
        private bool PiocheVide;
        private int NbJoueurs = 0;
        private List<Joueur> OrdredesJoueurs = new List<Joueur>();

        //Constructeur
        public Jeux(int NbJoueur)
        {
            this.NbJoueurs = NbJoueur;
        }


        //Getter et Setter
        public int NombreJoueurs
        {
            get { return this.NbJoueurs; }
        }
    }
}
