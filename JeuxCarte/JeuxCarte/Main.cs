using System;
using System.Collections.Generic;
using System.Text;



namespace JeuxCarte
{
    class Main
    {
        //Déclaration des variables encapsulées.
        List<Carte> listeCartes = new List<Carte>();
       

        //Getter et setter
        public int nbCartes
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
            bool OpComplete = true; 
            if (index < listeCartes.Count -1)
            {
                listeCartes.RemoveAt(index);
            }
            else
            {
                OpComplete = false;
            }

            return OpComplete;
        }

        public override string ToString()
        {
            return listeCartes.ToString();
        }

    }
}

