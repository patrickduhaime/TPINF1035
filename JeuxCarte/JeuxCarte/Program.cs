using System;

namespace JeuxCarte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bienvenue au jeux de la pioche***");

            Console.WriteLine("Combien de joueurs(2-4)");
            string nbJoueurs = Console.ReadLine();
            Jeux LeJeux = new Jeux(Int32.Parse(nbJoueurs));



            Console.WriteLine(LeJeux.NombreCartePioche);
            Console.ReadKey(); //Permet d'arreter la console.
        }
    }
}
