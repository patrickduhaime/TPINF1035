using System;
using System.Collections.Generic;
using System.Text;



namespace JeuxCarte
{
    class Main
    {
        //Déclaration des variables encapsulées.
        private List<Jeux.SCarte> listeCartes;

        //Constructeur de la classe Main
        public Main()
        {
            listeCartes = new List<Jeux.SCarte>();
        }

      
       

        //Getter et setter
        public int NbCartes
        {
            get { return listeCartes.Count; }
            
        }

        //Méthodes

        public void AjoutCarte(Jeux.SCarte carte)
        {
            listeCartes.Add(carte);
        }

        public bool EnleveCarte(int index)
        {
            bool OpCompletee = true; 
            if (index <= listeCartes.Count -1 || index == 0)
            {
                listeCartes.RemoveAt(index);
            }
            else
            {
                OpCompletee = false;
            }

            return OpCompletee;
        }

        public Jeux.SCarte IndexDeCarte(int index)
        {
            return listeCartes[index];
        }

        public void ListMain()
        {
            int i = 0;
          foreach ( Jeux.SCarte carte in listeCartes)
            {
                Console.WriteLine("Carte" + i + " {0} ", listeCartes[i]);
                i++;
            }
            Console.WriteLine("");
        }

        public int RechercherCarte(Jeux.SCarte carte)
        {
            int index = 99;
            int i = 0;
            foreach(Jeux.SCarte card in listeCartes)
            {
                if (carte.Sorte.Equals(card.Sorte) || carte.Valeur.Equals(card.Valeur))
                {
                    return i;
                }
                i++;
            }
            return index;
        }

        public override string ToString()
        {
            return listeCartes.ToString();
        }

    }
}

