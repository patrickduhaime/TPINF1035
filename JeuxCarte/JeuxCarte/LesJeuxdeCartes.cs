using System;
using System.Collections.Generic;
using System.Text;

namespace JeuCarte
{
    class LesJeuxdeCartes
    {
        protected List<SCarte> JeuxdeCartes;
        protected List<Joueur> ListedeJoueurs;
        protected int NbJoueurs = 0;

        //Méthodes
        public void AjoutJoueur(Joueur LeJoueur)
        {
            ListedeJoueurs.Add(LeJoueur);
        }

        protected void CreationDuJeuxdeCartes()
        {
            foreach (SCarte.EnumSorte Sorte in Enum.GetValues(typeof(SCarte.EnumSorte)))
            {
                foreach (SCarte.EnumValeur Valeur in Enum.GetValues(typeof(SCarte.EnumValeur)))
                {
                    SCarte UneCarte = new SCarte(Sorte, Valeur);
                    JeuxdeCartes.Add(UneCarte);
                }
            }
        }

        protected void MelangeListe<T>(List<T> LaListe)
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


        //Getter et Setter de la classe

        public int GetNombreJoueurs
        {
            get { return this.NbJoueurs; }
        }

        public List<Joueur> GetListdesJoueurs
        {
            get { return ListedeJoueurs; }
        }
        //Structure de carte
        public struct SCarte
        {
            //Constructeur
            public SCarte(EnumSorte sorte, EnumValeur valeur)
            {
                this.sorte = sorte;
                this.valeur = valeur;
            }

            //Énumération
            public enum EnumSorte { Coeur, Pique, Treffle, Carreau }
            public enum EnumValeur { As, deux, trois, quatre, cinq, six, sept, huit, neuf, dix, Valet, Dame, Roi }

            private EnumSorte sorte;
            private EnumValeur valeur;

            //Getter et setter de la struct carte
            public EnumSorte Sorte
            {
                get { return sorte; }
                set { sorte = value; }
            }

            public EnumValeur Valeur
            {
                get { return valeur; }
                set { valeur = value; }
            }


            //Méthodes
            public override string ToString()
            {
                return valeur + " de " + sorte;
            }


        }
    }
}
