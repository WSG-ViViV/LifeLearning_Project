using System;

namespace jeu_de_maths
{ 
    class Program
    {

        static bool PoserQuestion(int min, int max)
        {
            int reponseInt = 0;
            int bonneReponse = 0;
            bool resultat = false;
            while (true)
            {   
                Random random = new Random();

                int a = random.Next(min, max);
                int b = random.Next(min, max);

                Console.Write(a + " + " + b + " = ");
                string reponse = Console.ReadLine();
                try
                {
                    

                    /* reponseInt = int.Parse(reponse);
                     * if (reponseInt == a + b)
                     * {
                     * return true;
                     * }
                     * return false;
                     */

                     
                    reponseInt = int.Parse(reponse);
                    bonneReponse = a + b;
                    resultat = bonneReponse == reponseInt;
                    break;
                   

                }
                catch
                {
                    Console.WriteLine("ERREUR: Vous devez entre un nombre valide !!");
                }

            }
            return resultat;
        }


        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTION = 3;
            int score = 0;



            for (int i = 0; i < NB_QUESTION; i++)
            {
                Console.WriteLine("Question n° " + (i + 1) + "/" + NB_QUESTION + "!");
                bool resultat_1 = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX + 1);
                if (resultat_1)
                {
                    Console.WriteLine();
                    Console.WriteLine("+++");
                    Console.WriteLine("Félicitation, bonne réponse");
                    Console.WriteLine("+++");
                    score++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("---");
                    Console.WriteLine("Dommage, Mauvaise Réponse");
                    Console.WriteLine("---");
                }
                Console.WriteLine("");
            }
            Console.WriteLine(" Votre score est de " + score + "/" + NB_QUESTION + " !!");
        }
        
    }

}