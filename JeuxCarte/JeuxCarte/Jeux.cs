using System;
using System.Collections.Generic;
using System.Text;

namespace JeuxCarte
{
    class Jeux
    {
        //Déclartation des variables privées.
        private List<Carte> JeuxdeCartes;
        protected List<Carte> PileDepot;
        private List<Carte> Pioche;
        private List<Joueur> ListedeJoueurs;
        private bool PiocheVide = false;
        private int NbJoueurs = 0;
        private List<Joueur> OrdredesJoueurs;

        //Constructeur
        public Jeux(int NbJoueur)
        {
            this.NbJoueurs = NbJoueur;
            //Création des 52 cartes
            JeuxdeCartes = new List<Carte>();
            CreationDuJeuxdeCartes();
            MelangeListe(JeuxdeCartes); //Mélange le jeux après création
            PileDepot = new List<Carte>();
            ListedeJoueurs = new List<Joueur>();
            Pioche = new List<Carte>();
            OrdredesJoueurs = new List<Joueur>();
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
            get { return PileDepot.Count; }
        }

        public Carte GetCarteDepot
        {
            get { return PileDepot[PileDepot.Count - 1]; }
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
            int k = 0;

            while (k < 8 * GetNombreJoueurs)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int i = 0; i < GetNombreJoueurs; i++)
                    {
                        ListedeJoueurs[i].MainJoueur.AjoutCarte(JeuxdeCartes[k]);
                        JeuxdeCartes.RemoveAt(k++);
                    }
                }
            }
        }

        public void AjoutCartePileDepot(Carte carte)
        {
            PileDepot.Add(carte);
        }

        public void AfficherCartePileDepot(Carte carte)
        {
            Console.WriteLine("Carte de la pile de depot:  {0} {1}", carte.Valeur, carte.Sorte);
        }

        public void AjoutJoueur(Joueur LeJoueur)
        {
            ListedeJoueurs.Add(LeJoueur);
        }


        /*
         *Methode pour choisir le premier joueur aleatoirement et demarre la parti
         *en deposant une premiere carte sur la pile de depot
        */
        public void PremierJoueur()
        {
            Random rand = new Random();
            int index = rand.Next(0, GetNombreJoueurs - 1);
            int indexCarte = rand.Next(0, 7);
            AjoutCartePileDepot(ListedeJoueurs[index].MainJoueur.IndexDeCarte(indexCarte));
            ListedeJoueurs[index].MainJoueur.EnleveCarte(indexCarte);
            JoueurSuivant(index);
        }

        public void JoueurSuivant(int i)
        {
            i++;
            if (i >= GetNombreJoueurs)
                i = 0;
            Console.WriteLine("Joueur: " + ListedeJoueurs[i].NomJoueur);
            AfficherCartePileDepot(GetCarteDepot);
            ListedeJoueurs[i].MainJoueur.ListMain();

           int jouerOuPiocher = VerifieCarte(i, PileDepot.Count - 1);
            if (jouerOuPiocher == 99)
                piocher();
            else
            {
                AjoutCartePileDepot(ListedeJoueurs[i].MainJoueur.IndexDeCarte(jouerOuPiocher));
                ListedeJoueurs[i].MainJoueur.EnleveCarte(jouerOuPiocher);
            }

            if (ListedeJoueurs[i].MainJoueur.NbCartes == 0)
                Console.WriteLine("joueur" + i + "gagne !!!");
            else
            {
                System.Threading.Thread.Sleep(2000);
                JoueurSuivant(i);
            }
            
        }

        public void piocher()
        {
            Console.WriteLine("Le joueur pioche !!!\n");
        }

        public int VerifieCarte(int i, int j)
        {
            int index = 0;

            index = ListedeJoueurs[i].MainJoueur.rechercherCarte(PileDepot[j]);

            return index;
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
