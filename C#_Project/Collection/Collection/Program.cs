using System;



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
            Console.WriteLine("La valeur Maximale du tableau est : " + tableau.Max());
            Console.WriteLine("-_-_-_-_-_-_");

        }

        static void Main(string[] args)
        {
            //int[] t = { 10, 55, 12, 234, 3634, 123, 123, 453245, 4356, 14648 };
            
            int[] t = new int[10];
            Random rand = new Random();

            for (int j = 0; j < t.Length; j++)
            {
                t[j] = rand.Next(0, 100+1);
            }

            AfficherTableau(t);

            AfficherValeurMaximale(t);
            

        }
    }
}
