
using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Magic_Number
{
    class Program
    {
        static int DemanderNombre(int min, int max)
        {
            int nbrs = min -1;
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

            const int NBRS_MIN = 1;
            const int NBRS_MAX = 10;
            const int NBRS_MAGIQUE = 5;

            int nbrs = DemanderNombre(NBRS_MIN, NBRS_MAX);

            if (NBRS_MAGIQUE > nbrs)
                {
                    Console.WriteLine("Le nombres magique est superieur a : " + nbrs);
                }
            else if (NBRS_MAGIQUE < nbrs)
                {
                    Console.WriteLine("Le nombres magique est inferieur a : " + nbrs);
                }
            else
                {
                    Console.WriteLine("Félicitation, vous avez trouver le nombres magique :" + nbrs);
                }


        }
    }
}

