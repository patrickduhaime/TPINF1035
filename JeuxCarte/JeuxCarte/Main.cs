using System;
using System.Collections.Generic;
using System.Text;



namespace JeuxCarte
{
    class Main
    {
        //Déclaration des variables encapsulées.
        private List<Carte> listeCartes;

        //Constructeur de la classe Main
        public Main()
        {
            listeCartes = new List<Carte>();
        }

      
       

        //Getter et setter
        public int NbCartes
        {
            get { return listeCartes.Count; }
            
        }

        //Méthodes

        public void AjoutCarte(Carte carte)
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

        public Carte IndexDeCarte(int index)
        {
            return listeCartes[index];
        }

        public void ListMain()
        {
            int i = 0;
          foreach ( Carte carte in listeCartes)
            {
                Console.WriteLine("Carte" + i + " {0} ", listeCartes[i]);
                i++;
            }
            Console.WriteLine("");
        }

        public int RechercherCarte(Carte carte)
        {
            int index = 99;
            int i = 0;
            foreach(Carte card in listeCartes)
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

