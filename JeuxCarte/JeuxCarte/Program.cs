//TP1 INF1035
//Couture, Duhaime, Picard
using System;
using System.Collections.Generic;
using System.Text;

namespace JeuxCarte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bienvenue au jeux de la pioche***");
            //Demande le nombre de joueurs
            Console.WriteLine("Combien de joueurs(2-4)");
            int nbJoueurs = Int16.Parse(Console.ReadLine());  //Conversion String en Int
            Jeux LeJeux = new Jeux(nbJoueurs);

            //Demande le nom de chaque joueur
            for (int i = 1; i <= nbJoueurs; i++)
            {
                Console.WriteLine("Nom et Prenom du joueur {0} svp: ", i );
                String [] NomComplet = Console.ReadLine().Split(null); //Assume que l'entrée se fait par un espace entre les deux.
                LeJeux.AjoutJoueur(new Joueur(NomComplet[0], NomComplet[1]));
                
            }
            LeJeux.DistributCartes();
            foreach (Joueur LeJoueur in LeJeux.GetListdesJoueurs)
            {
                Console.WriteLine("Joueur: {0} {1}", LeJoueur.PrenomJoueur, LeJoueur.NomJoueur);
                LeJoueur.MainJoueur.ListMain();
            }
            Console.ReadKey(); //Permet d'arreter la console.


            //Affiche l'état du jeux
            Console.WriteLine("");
            Console.WriteLine("**************************************************");
            Console.WriteLine("*****************Etats du jeux********************");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Le nombre de joueurs est {0}", LeJeux.GetNombreJoueurs);
            foreach (Joueur LeJoueur in LeJeux.GetListdesJoueurs)
            {
                Console.WriteLine("Joueur: {0} {1}", LeJoueur.PrenomJoueur, LeJoueur.NomJoueur); 
            }
            Console.WriteLine("Melange de l'ordre des joueurs, voici le nouvel ordre");
            LeJeux.MelangeJoueurs();
            foreach (Joueur LeJoueur in LeJeux.GetListdesJoueurs)
            {
                Console.WriteLine("Joueur: {0} {1}", LeJoueur.PrenomJoueur, LeJoueur.NomJoueur);
            }
            Console.WriteLine("Le nombre de cartes dans la pioche: {0} cartes", LeJeux.GetNombreCartePioche);
            Console.WriteLine("Le jeux est brasse");
            Console.WriteLine("Est-ce que la pioche est vide? {0}", LeJeux.GetEtatPiocheVide);
            Console.ReadKey(); //Permet d'arreter la console.
        }
    }
}
