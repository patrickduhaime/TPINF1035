using System;
using System.Collections.Generic;
using System.Text;

namespace JeuxCarte
{
    class Carte
    {
        //Définition des énumérations
        public enum enumSorte { Coeur, Pique, Treffle, Carreau }
        public enum enumValeur { As, deux, trois, quatre, cinq, six, sept, huit, neuf, dix, Valet, Dame, Roi}
        
        //Déclaration des variables encapsulées.
        private enumSorte sorte;
        private enumValeur valeur;

        //Constructeur
        public Carte( enumSorte sorte, enumValeur valeur ){
            this.sorte = sorte;
            this.valeur = valeur;
        }

        //Getter et setter de la carte
        public enumSorte Sorte
        {
            get { return sorte; }
            set { sorte = value; }
        }

        public enumValeur Valeur
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
