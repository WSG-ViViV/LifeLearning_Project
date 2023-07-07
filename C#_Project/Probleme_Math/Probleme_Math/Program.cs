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
           
                bool resultat_1 = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX + 1);
                if (resultat_1)
                {
                    Console.WriteLine("Félicitation, bonne réponse");
                }
                else
                {
                    Console.WriteLine("Dommage, Mauvaise Réponse");
                }
            
            
        }
        
    }

}