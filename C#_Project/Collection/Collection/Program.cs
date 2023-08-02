using System;
using System.Threading.Channels;

namespace Collection
{
    class Program
    {

        static void AfficherTableau(int[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + tableau[i]);
            }
        }


        static void Tableaux()
        {
            int[] t = new int[20];
            Random rand = new Random();

            for (int j = 0; j < t.Length; j++)
            {
              t[j] = rand.Next(0, int.MaxValue);
            }
        }


        static void AfficherValeurMaximale(int[] tableau)
        {
            Console.WriteLine();
            Console.WriteLine("-_-_-_-_-_-_");
            Console.WriteLine("La valeur maximale du tableau est : " + tableau.Max());
            Console.WriteLine("-_-_-_-_-_-_");

        }

        static void AfficherValeurMinimal(int[] tableau)
        {
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine("La valeur minimal du tableau est : " + tableau.Min());
            Console.WriteLine("---------------");
        }

        static void SommeTableau(int[] tableau)
        {
            int somme = 0;
            for (int i = 0; i < tableau.Length; i++)
            {
                somme += tableau[i];
            }
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++");
            Console.WriteLine("La somme du tableau est : " + somme);
            Console.WriteLine("+++++++++++++++");

        }

        static void Main(string[] args)
        {
            //int[] t = { 10, 55, 12, 234, 3634, 123, 123, 453245, 4356, 14648 };
            
            
            Random rand = new Random();
            int tailleTableau = rand.Next(1, 19+1);
            int[] t = new int[tailleTableau];

            for (int j = 0; j < t.Length; j++)
            {
                t[j] = rand.Next(0, 100+1);
            }

            AfficherTableau(t);

            AfficherValeurMaximale(t);

            AfficherValeurMinimal(t);

            SommeTableau(t);

            Console.WriteLine();
            Console.WriteLine("Fin du script =))");
            


        }
    }
}
