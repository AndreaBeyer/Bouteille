using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bouteille
{
    class Program
    {
        static void Main(string[] args)
        {
            string matiereEmballage;
            string reponseMatiereEmballage;
            bool recommence = true, recommence1 = true, ok;
            int i = 0;
            int numeroASupprimer;

            PackDeBouteille packDeBouteille = new PackDeBouteille();

            Console.WriteLine("Gestion de pack de bouteilles");

            do
            {
                Console.WriteLine("De quel matiere souhaitez vous l'emballage? (carton, plastique, filet)");
                reponseMatiereEmballage = Console.ReadLine();
            } while (!packDeBouteille.ResolveMatiereEmballage(reponseMatiereEmballage));

            matiereEmballage = packDeBouteille.GetMatiereEmballageToString();

            while (recommence)
            {
                Console.WriteLine("Bouteille numero : " + (i+1));
                Console.WriteLine("Quel est le prix de la bouteille");
                double temp = double.Parse(Console.ReadLine());
                Console.WriteLine("est elle ouverte ? o/n");
                bool ouverte = (Console.ReadLine().ToLower() == "o");
                Console.WriteLine("Quel est son taux de remplissage");
                double temp1 = double.Parse(Console.ReadLine());
                Bouteille tempB = new Bouteille(ouverte, temp1, temp);
                try 
                {
                    packDeBouteille.Ajouter(tempB);
                    Console.WriteLine("l'ajout a reussi");
                    i++;
                }
                catch
                {
                    Console.WriteLine("l'ajout a echoue");
                }
                Console.WriteLine("le pack contient " + i + " bouteilles");
                Console.WriteLine("Voulez vous aujouter une nouvelle bouteille? o/n");
                recommence = (Console.ReadLine().ToLower() == "o");
                
            }

            Console.WriteLine(packDeBouteille.GetString());
            Console.WriteLine("la matiere utiliser pour l'emballage est : " + matiereEmballage);
            Console.WriteLine("le prix cumulé du pack est de : {0} euros", packDeBouteille.CalculerPrixPack());
            Console.WriteLine();

            Console.WriteLine("Voulez vous supprimer une bouteille? o/n");
            recommence1 = (Console.ReadLine().ToLower() == "o");

            while (recommence1)
            {
                do
                {
                    Console.WriteLine("Quel est le numero de la bouteille");
                    ok = (int.TryParse(Console.ReadLine(), out numeroASupprimer));
                } while (!ok);

                try
                {
                    packDeBouteille.Retirer(packDeBouteille.GetBouteille(numeroASupprimer - 1));
                    Console.WriteLine("la suppression de la bouteille numero {0} a reussie", (numeroASupprimer));
                }
                catch
                {
                    Console.WriteLine("la suppression de la bouteille numero {0} a echoue", (numeroASupprimer));
                }

                Console.WriteLine("Voulez vous supprimer une  nouvelle bouteille? o/n");
                recommence1 = (Console.ReadLine().ToLower() == "o");
            }

            Console.WriteLine(packDeBouteille.GetString());
            Console.WriteLine("la matiere utiliser pour l'emballage est : " + matiereEmballage);
            Console.WriteLine("le prix cumulé du pack est de : {0} euros", packDeBouteille.CalculerPrixPack());
            Console.ReadKey();

        //    Console.WriteLine("Outil de manipulation d'objet");
        //    do
        //    {
        //        do
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine("quel operation voulez vous faire?");
        //            Console.WriteLine("1- Ouvrir\t2-Fermer\t3-Remplir\t4-Vider\t5-Afficher son etat\t6-Quitter");
        //            reponse = Console.ReadLine();
        //            ok = (reponse.ToLower() == "1" || reponse.ToLower() == "2" || reponse.ToLower() == "3" || reponse.ToLower() == "4" || reponse == "5" || reponse =="6");
        //        } while (!ok);
        //        switch (reponse)
        //        {
        //            case "1":
        //                if (evian.Ouvrir())
        //                {
        //                    Console.WriteLine("l'operation a reussie");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("l'operation a echoue");
        //                }
        //                break;
        //            case "2":
        //                if (evian.Fermer())
        //                {
        //                    Console.WriteLine("l'operation a reussie");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("l'operation a echoue");
        //                }
        //                break;
        //            case "3":
        //                Console.WriteLine("de quel pourcentage souhaitez vous remplir?");
        //                string temp1 = "";
        //                temp1 = Console.ReadLine();
        //                try
        //                {
        //                    pourcentage = double.Parse(temp1);
        //                    if (evian.Remplir(pourcentage))
        //                    {
        //                        Console.WriteLine("le remplissage a reussi");
        //                    }
        //                    else
        //                    {
        //                        if (temp1 == "")
        //                        {
        //                            evian.Remplir();
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("le remplissage a echoue");
        //                        }
                                
        //                    }
        //                }
        //                catch
        //                {
        //                    Console.WriteLine("L'entree est invalide");
        //                }

        //                break;
        //            case "4":
        //                Console.WriteLine("de quel pourcentage souhaitez vous vider?");
        //                string temp = Console.ReadLine();
        //                try
        //                {
        //                    pourcentage = double.Parse(temp);

        //                        if (evian.Vider(pourcentage))
        //                        {
        //                            Console.WriteLine("le Vidage a reussi");
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("le Vidage a echoue");
        //                        }
        //                }
        //                catch
        //                {
        //                    if (temp == "")
        //                    {
        //                        evian.Vider();
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("L'entree est invalide"); 
        //                    }
                            
        //                }
        //                break;
        //            case "5":
        //                break;
        //            case "6":
        //                ok1 = false;
        //                break;
        //        }
        //        if (ok1)
        //        {
        //            if (evian.GetEstOuvert())
        //            {
        //                Console.WriteLine("La bouteille est ouverte");
        //            }
        //            else
        //            {
        //                Console.WriteLine("la bouteille est fermee");
        //            }
        //            Console.WriteLine("le taux de remplissage est de : {0} %", evian.GetTauxDeRemplissage());
        //        }
                
                
        //    } while (ok1);
        }
    }
}
