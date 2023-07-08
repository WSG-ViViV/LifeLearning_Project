using System;


namespace Password_Gen
{

    class Program
    {

        static int DemanderNombre(string question)
        { 
            while (true)
            {
                Console.WriteLine(question);
                string longeurPass = Console.ReadLine();
                try
                {
                   int longeurPassInt = int.Parse(longeurPass);
                    if (longeurPassInt <= 0)
                    {
                        Console.WriteLine("Le nombre ne peux pas etre negatif !");
                    }
                    else
                    {
                        return longeurPassInt;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("ERREUR: Veuillez entrer un nombre valide!!");
                } 
            }
        }

        static void Main(string[] args)
        {
             int longeurPassword = DemanderNombre("Longeur du mot de passe ?");
        }
    }
}


