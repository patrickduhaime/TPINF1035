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
        private Stack<Carte> Pioche;
        private List<Joueur> ListedeJoueurs;
        private bool PiocheVide = false;
        private int NbJoueurs = 0;

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
            Pioche = new Stack<Carte>();
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
            int l = 0;

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

            while (l  <= JeuxdeCartes.Count - 1)
                    Pioche.Push(JeuxdeCartes[l++]);
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

        private void JoueurSuivant(int i)
        {
            i++;
            if (i >= GetNombreJoueurs)
                i = 0;

            Console.WriteLine("Joueur: " + ListedeJoueurs[i].NomJoueur);
            AfficherCartePileDepot(GetCarteDepot);
            ListedeJoueurs[i].MainJoueur.ListMain();

           int jouerOuPiocher = VerifieCarte(i, PileDepot.Count - 1);
            if (jouerOuPiocher == 99)
                Piocher(ListedeJoueurs[i]);
            else
            {
                AjoutCartePileDepot(ListedeJoueurs[i].MainJoueur.IndexDeCarte(jouerOuPiocher));
                ListedeJoueurs[i].MainJoueur.EnleveCarte(jouerOuPiocher);
            }

            if (ListedeJoueurs[i].MainJoueur.NbCartes.Equals(0))
            {
                Console.WriteLine("joueur" + i + "gagne !!!");
            }
            else
            {
                System.Threading.Thread.Sleep(2000);
                JoueurSuivant(i);
            }
        }

        private void Piocher(Joueur joueur)
        {
            Console.WriteLine("Le joueur pioche !!!\n");
            if (Pioche.Count == 0)
            {
                RemplirPioche();
            }
            joueur.MainJoueur.AjoutCarte(Pioche.Pop());
        }



        private int VerifieCarte(int i, int j)
        {
           int index = ListedeJoueurs[i].MainJoueur.RechercherCarte(PileDepot[j]);

            return index;
        }

        private void RemplirPioche()
        {
            Carte carteDepot = PileDepot[PileDepot.Count - 1];
            PileDepot.Remove(carteDepot);
            MelangeListe(PileDepot);

            foreach (Carte carte in PileDepot)
            {
                Pioche.Push(carte);
            }

            PileDepot.Clear();
            PileDepot.Add(carteDepot);

            Console.WriteLine("Pile de pioche rempli !!!\n");
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
