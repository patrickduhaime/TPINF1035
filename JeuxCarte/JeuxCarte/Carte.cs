using System;
using System.Collections.Generic;
using System.Text;

namespace JeuxCarte
{
    class Carte
    {
        //Définition des énumérations
        public enum EnumSorte { Coeur, Pique, Treffle, Carreau }
        public enum EnumValeur { As, deux, trois, quatre, cinq, six, sept, huit, neuf, dix, Valet, Dame, Roi}
        
        //Déclaration des variables encapsulées.
        private EnumSorte sorte;
        private EnumValeur valeur;

        //Constructeur
        public Carte(EnumSorte sorte, EnumValeur valeur ){
            this.sorte = sorte;
            this.valeur = valeur;
        }

        //Getter et setter de la carte
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
