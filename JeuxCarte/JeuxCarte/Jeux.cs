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
        //private List<Carte> Pioche = new List<Carte>();  Ajit sur la pile directement
        private List<Joueur> ListedeJoueurs = new List<Joueur>();
        private bool PiocheVide = false;
        private int NbJoueurs = 0;
        private List<Joueur> OrdredesJoueurs = new List<Joueur>();

        //Constructeur
        public Jeux(int NbJoueur)
        {
            this.NbJoueurs = NbJoueur;
            //Création des 52 cartes
            CreationDuJeuxdeCartes();
            MelangeListe(JeuxdeCartes); //Mélange le jeux après création
        }

        //Getter et Setter
        public int GetNombreJoueurs
        {
            get { return this.NbJoueurs; }
        }
        public int GetNombreCartePioche
        {
            get { return JeuxdeCartes.Count; }
        }

        public int GetNombreCartePile
        {
            get { return Pile.Count; }
        }

        public bool GetEtatPiocheVide
        {
            get {
                 if (JeuxdeCartes.Count == 0)
                {
                    PiocheVide = true;
                }
                else
                {
                    PiocheVide = false;
                }
            return PiocheVide; }
        }

        public List<Joueur> GetListdesJoueurs
        {
            get { return ListedeJoueurs; }
        }

        //Méthodes

        public void DistributCartes()
        {

        }

        public void AjoutJoueur(Joueur LeJoueur)
        {
            ListedeJoueurs.Add(LeJoueur);
        }



        private void CreationDuJeuxdeCartes()
        {
            foreach (Carte.EnumSorte Sorte in Enum.GetValues(typeof(Carte.EnumSorte)))
            {
                foreach (Carte.EnumValeur Valeur in Enum.GetValues(typeof(Carte.EnumValeur)))
                {
                    Carte UneCarte = new Carte(Sorte, Valeur);
                    JeuxdeCartes.Add(UneCarte);
                }
            }
        }

        public void MelangeJoueurs()
        {
            MelangeListe(this.ListedeJoueurs);
        }

        private void MelangeListe<T>(List<T> LaListe)
        {
            Random rnd = new Random();
            int n = LaListe.Count;
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = LaListe[k];
                LaListe[k] = LaListe[n];
                LaListe[n] = value;
            }
        }
    }
}
