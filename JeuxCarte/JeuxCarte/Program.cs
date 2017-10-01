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
            while (true)
            {
                Console.WriteLine("***Bienvenue au jeux de la pioche***");
                Console.WriteLine("Pour débuter la partie, taper 1");
                Console.WriteLine("Pour quitter, taper 0");

                String choix = Console.ReadLine();


                switch (choix)
                {
                    case "0":
                        Console.WriteLine("Au revoir !");
                        Environment.Exit(0);
                        break;

                    case "1":

                        int nbJoueurs = 0;
                        String nombreJoueur;

                        Console.WriteLine("Entrer le nombre de joueur a creer entre 2 et 4");
                        nombreJoueur = Console.ReadLine();
                        nbJoueurs = (int.Parse(nombreJoueur));

                        while (nbJoueurs < 2 || nbJoueurs > 4)
                        {
                            Console.WriteLine("Entrer le nombre de joueur a creer entre 2 et 4");
                            nombreJoueur = Console.ReadLine();
                            nbJoueurs = (int.Parse(nombreJoueur));
                        }
                        Jeux LeJeux = new Jeux(nbJoueurs);

                        switch (nombreJoueur)
                        {
                            case "2":
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Premier joueur******************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur1 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur1 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur1, pJoueur1));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Deuxième joueur*****************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur2 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur2 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur2, pJoueur2));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("***************La partie va commencer*************");
                                Console.WriteLine("**************************************************");

                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Les cartes sont distribues aux joueurs\n");
                                LeJeux.DistributCartes();
                                System.Threading.Thread.Sleep(2000);
                                LeJeux.PremierJoueur();
                                break;

                            case "3":
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Premier joueur******************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur3 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur3 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur3, pJoueur3));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Deuxième joueur*****************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur4 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur4 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur4, pJoueur4));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Troisième joueur*****************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur5 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur5 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur5, pJoueur5));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("***************La partie va commencer*************");
                                Console.WriteLine("**************************************************");

                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Les cartes sont distribues aux joueurs\n");
                                LeJeux.DistributCartes();
                                System.Threading.Thread.Sleep(2000);
                                LeJeux.PremierJoueur();
                                break;

                            case "4":
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Premier joueur******************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur6 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur6 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur6, pJoueur6));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Deuxième joueur*****************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur7 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur7 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur7, pJoueur7));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Troisième joueur****************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur8 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur8 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur8, pJoueur8));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("******************Quatrième joueur****************");
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("Entrer le nom:");
                                String nJoueur9 = Console.ReadLine();
                                Console.WriteLine("Entrer le prenom:");
                                String pJoueur9 = Console.ReadLine();
                                LeJeux.AjoutJoueur(new Joueur(nJoueur9, pJoueur9));
                                Console.WriteLine("**************************************************");
                                Console.WriteLine("***************La partie va commencer*************");
                                Console.WriteLine("**************************************************");

                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("Les cartes sont distribues aux joueurs\n");
                                LeJeux.DistributCartes();
                                System.Threading.Thread.Sleep(2000);
                                LeJeux.PremierJoueur();
                                break;
                        }
                        break;
                }
            }
        }
    }
}