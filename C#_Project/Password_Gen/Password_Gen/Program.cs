using System;
using FormationCS;

namespace Password_Gen
{

    class Program
    {

        static void Main(string[] args)
        {

            const int MINIMUM = 1;
            const int MAXIMUM = 10;

            int longeurPassword = outils.DemanderNombreEntre("Longeur du mot de passe ?", MINIMUM, MAXIMUM);
            Console.WriteLine("vous avez taper: " +  longeurPassword);
            int nombrePositif = outils.DemanderNombrePositifNonNul("Nombre iteration ?");
            Console.WriteLine("Vous avez choisis " + nombrePositif + " iteration !");
        }
    }
}


