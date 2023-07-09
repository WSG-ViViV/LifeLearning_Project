using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }


        public static int DemanderNombreEntre(string question, int min, int max)
        {

            int nombres = DemanderNombre(question);

            if ((nombres >= min) && (nombres <= max))
            {
                return nombres;
            }
            else
            {
                Console.WriteLine("Veuillez entrer un nombre compris entre " + min + " et " + max);
                return DemanderNombreEntre(question, min, max);
            }
        }




        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                string longeurPass = Console.ReadLine();
                try
                {
                    int longeurPassInt = int.Parse(longeurPass);
                    return longeurPassInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR: Veuillez entrer un nombre valide!!");
                }
            }
        }

    }
}
