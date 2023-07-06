
using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace Magic_Number
{
    class Program
    {
        static int DemanderNombre(int min, int max)
        {
            int nbrs = min - 1;
            while ((nbrs < min) || (nbrs > max))
            {
                Console.WriteLine("Veuillez entrer un nombre compris entre " + min + " et " + max);
                string nbrs_str = Console.ReadLine();


                try
                {
                    nbrs = int.Parse(nbrs_str);

                    if ((nbrs < min) || (nbrs > max))
                    {
                        Console.WriteLine("le nombres doit etre comris entre " + min + " et " + max + ":");
                    }


                }
                catch
                {
                    Console.WriteLine("Erreur vous devez entrer un nombre valide.");
                }
            }
            return nbrs;
        }


        static void Main(string[] args)
        {
            Random rand = new Random();

            const int NBRS_MIN = 1;
            const int NBRS_MAX = 10;
            int NBRS_VIE = 4;

            int NBRS_MAGIQUE = rand.Next(NBRS_MIN, NBRS_MAX + 1);

            int nbrs = NBRS_MAGIQUE + 1;

            while ((NBRS_MAGIQUE != nbrs) && (NBRS_VIE != 0))
            {
                Console.WriteLine("");
                Console.WriteLine("Vie restantes : " + NBRS_VIE);
                nbrs = DemanderNombre(NBRS_MIN, NBRS_MAX);

                if (NBRS_MAGIQUE > nbrs)
                {
                    Console.WriteLine("Le nombres magique est superieur a : " + nbrs);
                    Console.WriteLine("");
                    Console.WriteLine("Il vous reste " + (NBRS_VIE - 1) + " essaie !!");
                }
                else if (NBRS_MAGIQUE < nbrs)
                {
                    Console.WriteLine("Le nombres magique est inferieur a : " + nbrs);
                    Console.WriteLine("");
                    Console.WriteLine("Il vous reste " + (NBRS_VIE -1) + " essaie !!");
                }
                else
                {
                    // Nombre magique trouvé
                    break;
                }
                NBRS_VIE--;
            }
            if (NBRS_MAGIQUE == nbrs)
            {
                Console.WriteLine("");
                Console.WriteLine("+++");
                Console.WriteLine("Félicitation, vous avez trouver le nombres magique : " + nbrs);
                Console.WriteLine("+++");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("---");
                Console.WriteLine("Perdu, vos vie sont epuisé");
                Console.WriteLine("Le nombre magique etait : " +NBRS_MAGIQUE);
                Console.WriteLine("---");
            }
           
        }

    }
}

