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
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR: Veuillez entrer un nombre positif non null");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messagePerso = null)
        {

            int nombres = DemanderNombre(question);
            Console.WriteLine();
            if ((nombres >= min) && (nombres <= max))
            {
                return nombres;
            }
            if (messagePerso == null)
            {
                Console.WriteLine("---");
                Console.WriteLine("ERREUR: Veuillez entrer un nombre compris entre " + min + " et " + max);
                Console.WriteLine("---");
               
            }
            else
            {
                Console.WriteLine("---");
                Console.WriteLine(messagePerso);
                Console.WriteLine("---");
            }
            Console.WriteLine();
            return DemanderNombreEntre(question, min, max, messagePerso);
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
                    Console.WriteLine("---");
                    Console.WriteLine("ERREUR: Veuillez entrer un nombre valide!!");
                    Console.WriteLine("---");
                }
            }
        }

        public static string GenPassword(string alphabet, int longeurPassword, int pattern = 0)
        {
            Random rand = new Random();
            string motDePasse = "";
            int longeurAlphabet = alphabet.Length;
            if (pattern == 0)
            {
                for (int i = longeurPassword; i != 0; i--)
                {
                    int index = rand.Next(0, longeurAlphabet);
                    motDePasse += alphabet[index];

                }
                return motDePasse;
            }
            else if (pattern == 1)
            {
                for (int j = 0; j < 4; j++)
                {
                    // Fonction pour la gen de mot de passe swisscom
                    int index = rand.Next(0, longeurAlphabet);
                    motDePasse += alphabet[index];
                }
                return motDePasse;
            }
            else
            {
                Console.WriteLine("ERREUR Veuillez choisir un pattern valide!");
                return GenPassword(alphabet,longeurPassword,pattern);
            }
            
        }

    }
}
