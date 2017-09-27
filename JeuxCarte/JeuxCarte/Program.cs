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
            Console.WriteLine("Partie de 3 Joueurs");
            int nbJoueurs = 3;
            Jeux LeJeux = new Jeux(nbJoueurs);

            //Demande le nom de chaque joueur
            LeJeux.AjoutJoueur(new Joueur("Patrick", "Duhaime"));
            LeJeux.AjoutJoueur(new Joueur("Francis", "Picard"));
            LeJeux.AjoutJoueur(new Joueur("Martin", "Couture"));
            System.Threading.Thread.Sleep(2000);
            LeJeux.DistributCartes();
            LeJeux.PremierJoueur();
            LeJeux.AfficherCartePileDepot(LeJeux.GetCarteDepot);

            foreach (Joueur LeJoueur in LeJeux.GetListdesJoueurs)
            {
                Console.WriteLine("Joueur: {0} {1}", LeJoueur.PrenomJoueur, LeJoueur.NomJoueur);
                LeJoueur.MainJoueur.ListMain();
                System.Threading.Thread.Sleep(2000);
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
