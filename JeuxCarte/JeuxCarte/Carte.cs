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
        
        //Déclaration des varibles encapsulées.
        private string sorte = "";
        private string valeur = "";

        //Constructeur
        public Carte( enumSorte sorte, enumValeur valeur ){
            sorte = sorte;
            valeur = valeur;
        }

        //Getter et setter de la carte
        public string Sorte
        {
            get { return sorte; }
            set { sorte = value; }
        }

        public string Valeur
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
