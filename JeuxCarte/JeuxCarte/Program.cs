//TP1 INF1035
//Couture, Duhaime, Picard
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JeuxCarte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bienvenue au jeux de la pioche***");
            //Le nombre de joueurs
            Console.WriteLine("***  Partie test pour 3 Joueurs  ***\n");

            int nbJoueurs = 3;
            Jeux LeJeux = new Jeux(nbJoueurs);

            //Demande le nom de chaque joueur
            LeJeux.AjoutJoueur(new Joueur("Patrick", "Duhaime"));
            LeJeux.AjoutJoueur(new Joueur("Francis", "Picard"));
            LeJeux.AjoutJoueur(new Joueur("Martin", "Couture"));

            int i = 1;
            foreach (Joueur LeJoueur in LeJeux.GetListdesJoueurs)
            {
                Console.WriteLine("Joueur" + (i++) + ": {0} {1}", LeJoueur.PrenomJoueur, LeJoueur.NomJoueur);
            }

            Console.WriteLine("");

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Les cartes sont distribues aux joueurs\n");
            LeJeux.DistributCartes();
            System.Threading.Thread.Sleep(2000);
            LeJeux.PremierJoueur();

            
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
