using System;

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
                Console.WriteLine("Nom du joueur {0} svp: ", i );
                Joueur LeJoueur = new Joueur(Console.ReadLine());
            }

            Console.WriteLine(LeJeux.NombreJoueurs);
            Console.WriteLine(LeJeux.NombreCartePioche);
            Console.ReadKey(); //Permet d'arreter la console.
        }
    }
}
