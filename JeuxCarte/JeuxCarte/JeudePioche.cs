using System;
using System.Collections.Generic;
using System.Text;

namespace JeuCarte
{
    class JeudePioche:LesJeuxdeCartes
    {
        //Déclartation des variables privées.
         private List<SCarte> PileDepot;
         private Stack<SCarte> Pioche;
         private bool PiocheVide = false;
 

        //Constructeur
        public JeudePioche(int NbJoueur)
        {
            this.NbJoueurs = NbJoueur;
            //Création des 52 cartes
            JeuxdeCartes = new List<SCarte>();
            CreationDuJeuxdeCartes();
            MelangeListe(JeuxdeCartes); //Mélange le jeux après création
            PileDepot = new List<SCarte>();
            ListedeJoueurs = new List<Joueur>();
            Pioche = new Stack<SCarte>();
        }

        //Getter et Setter

        public int GetNombreCartePioche
        {
            get { return JeuxdeCartes.Count; }
        }

        public int GetNombreCartePile
        {
            get { return PileDepot.Count; }
        }

        public SCarte GetCarteDepot
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

        //Méthodes pour distribuer les cartes aleatoirement aux joueurs

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

            //Les cartes non distribuees sont ajoutees a la pile de pioche
            while (l  <= JeuxdeCartes.Count - 1)
                    Pioche.Push(JeuxdeCartes[l++]);
        }

        //Methode pour ajouter une carte sur la pile de depot
        public void AjoutCartePileDepot(SCarte carte)
        {
            PileDepot.Add(carte);
        }

        //Methode pour afficher la carte sur la pile de depot
        public void AfficherCartePileDepot(SCarte carte)
        {
            Console.WriteLine("Carte de la pile de depot:  {0} {1}", carte.Valeur, carte.Sorte);
        }
 
        //Methode pour choisir le premier joueur aleatoirement et demarrer la parti
         //en deposant une premiere carte sur la pile de depot
        public void PremierJoueur()
        {
            Random rand = new Random();
            int index = rand.Next(0, GetNombreJoueurs - 1);
            int indexCarte = rand.Next(0, 7);
            AjoutCartePileDepot(ListedeJoueurs[index].MainJoueur.IndexDeCarte(indexCarte));
            ListedeJoueurs[index].MainJoueur.EnleveCarte(indexCarte);
            JoueurSuivant(index);
        }

        //Methode recursive qui incremente le joueur courant et qui verifie si le il peux jouer une carte ou si il doit piocher
        //La condition de sorti de la methode est que le joueur n'a plus de carte dans sa main.
        private void JoueurSuivant(int i)
        {
            i++;
            if (i >= GetNombreJoueurs)
                i = 0;

            Console.WriteLine("Joueur: " + ListedeJoueurs[i].NomJoueur);
            AfficherCartePileDepot(GetCarteDepot);
            ListedeJoueurs[i].MainJoueur.ListMain();

           int jouerOuPiocher = ListedeJoueurs[i].MainJoueur.RechercherCarte(PileDepot[PileDepot.Count - 1]);
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

        //Methode pour ajouter une carte de la pile de pioche a la main du joueur passe en parametre a la methode
        private void Piocher(Joueur joueur)
        {
            Console.WriteLine("Le joueur pioche !!!\n");
            if (Pioche.Count == 0)
            {
                RemplirPioche();
            }
            joueur.MainJoueur.AjoutCarte(Pioche.Pop());
        }

        //Methode pour remplir la pile de pioche avec les cartes de la pile de depot si la pile de pioche est vide.
        //La carte courante de la pile de depot reste la seule carte de la pile, les autre cartes sont melange
        //et ajouter a la pile de pioche
        private void RemplirPioche()
        {
            SCarte carteDepot = PileDepot[PileDepot.Count - 1];
            PileDepot.Remove(carteDepot);
            MelangeListe(PileDepot);

            foreach (SCarte carte in PileDepot)
            {
                Pioche.Push(carte);
            }

            PileDepot.Clear();
            PileDepot.Add(carteDepot);

            Console.WriteLine("Pile de pioche rempli !!!\n");
        }
     }
}
