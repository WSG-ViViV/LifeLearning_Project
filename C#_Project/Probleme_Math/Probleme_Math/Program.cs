using System;

namespace jeu_de_maths
{ 
    class Program
    {

        static void PoserQuestion()
        {
            int reponseInt = 0;
            while (true)
            {
                Console.Write("5 + 2 = ");
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    break;
                }
                catch
                {
                    Console.WriteLine("ERREUR: Vous devez entre un nombre valide !!");
                }
            }
           
        }


        static void Main(string[] args)
        {
            PoserQuestion();
        }
        
    }

}