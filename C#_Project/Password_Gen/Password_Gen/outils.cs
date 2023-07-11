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
                Console.WriteLine();
                return DemanderNombreEntre(question, min, max);
            }
        }

        public static int DemanderNombre(string question)
        {
            while (true)
            {
                Console.Write(question);
                string longeurPass = Console.ReadLine();
                try
                {
                    int longeurPassInt = int.Parse(longeurPass);
                    return longeurPassInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR: Veuillez entrer un nombre valide!!");
                    Console.WriteLine();
                }
            }
        }

        public static string GenPassword(string alphabet, int longeurPassword)
        {
            Random rand = new Random();
            string motDePasse = "";
            int longeurAlphabet = alphabet.Length;
            for (int i = longeurPassword; i != 0; i--)
            {
                int index = rand.Next(0, longeurAlphabet);
                motDePasse += alphabet[index];

            }
            return motDePasse;
        }
    }
}
