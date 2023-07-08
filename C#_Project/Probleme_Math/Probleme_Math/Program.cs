using System;

namespace jeu_de_maths
{ 
    class Program
    {
        enum E_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3,
            DIVISION = 4,
            PUISSANCE = 5 

        }
        static bool PoserQuestion(int min, int max)
        {
            float reponseInt = 0f;

            while (true)
            {   
                Random random = new Random();

                int a = random.Next(min, max);
                int b = random.Next(min, max);
                E_Operateur o = (E_Operateur)random.Next(1, 4); // Puissance a implement
                float resultatAttendu = 0f;

                switch (o)
                {
                    case E_Operateur.ADDITION:
                        Console.WriteLine(a + " + " + b + " =");
                        resultatAttendu = a + b;
                        break;
                    case E_Operateur.MULTIPLICATION:
                        Console.WriteLine(a + " x " + b + " =");
                        resultatAttendu = a * b;
                        break;
                    case E_Operateur.SOUSTRACTION:
                        if (a > b)
                        {
                            Console.WriteLine(a + " - " + b + " =");
                            resultatAttendu = a - b;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(b + " - " + a + " =");
                            resultatAttendu = b - a;
                            break;
                        }
                    case E_Operateur.DIVISION:
                        Console.WriteLine(a + " / " + b + " =");
                        resultatAttendu = a / b;
                        break;
                    case E_Operateur.PUISSANCE:
                        Console.WriteLine(a + " ^ " + b + " =");
                        //resultatAttendu = a ** b;
                        break;
                    default:
                        Console.WriteLine("ERREUR: Operateur invalide !");
                        break;

                }


                /*
                if (o == E_Operateur.ADDITION)
                {
                    Console.WriteLine(a + " + " + b + " =");
                    resultatAttendu = a + b;
                }
                else if (o == E_Operateur.MULTIPLICATION)
                {
                    Console.WriteLine(a + " x " + b + " =");
                    resultatAttendu = a * b;
                }
                else if (o == E_Operateur.SOUSTRACTION)
                {
                    Console.WriteLine(a + " - " + b + " =");
                    resultatAttendu = a - b;
                }
                else if (o == E_Operateur.DIVISION)
                {
                    Console.WriteLine(a + " / " + b + " =");
                    resultatAttendu = a / b;
                }
                else if (o == E_Operateur.PUISSANCE)
                {
                    Console.WriteLine(a + " ^ " + b + " =");
                    //resultatAttendu = a ** b;
                }
                else
                {
                    Console.WriteLine("ERREUR: Operateur invalide !"); 
                }
                */

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

                     
                    reponseInt = float.Parse(reponse);
                    if (reponseInt == resultatAttendu) 
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("ERREUR: Vous devez entre un nombre valide !!");
                }

            }
        }


        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTION = 10;
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
            Console.WriteLine("Bonne réponse " + score + " sur " + NB_QUESTION);
            float moyenne = NB_QUESTION / 2f;

            if (score == NB_QUESTION)
            {
                Console.WriteLine("Excellent !!!");
            }
            else if (score == 0) 
            {
                Console.WriteLine("Réviser vos maths !!!");
            }
            else if (score > moyenne)
            {
                Console.WriteLine("Pas mal !!");
            }
            else
            {
                Console.WriteLine("Peux mieux faire !");
            }
        }
        
    }

}