using System;
using FormationCS;

namespace Password_Gen
{

    class Program
    {

        static void Main(string[] args)
        {

            static string GenPassword(string alphabet, int longeurPassword)
            {
                Random rand = new Random();
                string motDePasse = "";
                int longeurAlphabet = alphabet.Length;
                for (int i = longeurPassword; i != 0; i--)
                {
                    ;
                    int index = rand.Next(0, longeurAlphabet);
                    motDePasse += alphabet[index];

                }
                return motDePasse;
            }


            int longeurPassword = outils.DemanderNombreEntre("Longeur du mot de passe ?", 1, int.MaxValue);
            //Console.WriteLine("vous avez taper: " +  longeurPassword);
            //int nombrePositif = outils.DemanderNombrePositifNonNul("Nombre iteration ?");
            //Console.WriteLine("Vous avez choisis " + nombrePositif + " iteration !");
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caractereSpeciaux = "+*%&/()=?`^,.@#€";
            string alphabet;
            

            

            int reponse = outils.DemanderNombreEntre("Quel caractère dois contenir le mot de passe; \n" +
                "1 - Uniquement des caractère en minuscule \n2 - Des caractère minuscule et majuscule \n" +
                "3 - Des caractère et des chiffres \n4 - Caractères, chiffres et caractères spéciaux \n", 1, 4);
            switch (reponse)
            {
                case 1:
                    {
                        alphabet = minuscules;
                        break;
                    }
                case 2:
                    {
                        alphabet = minuscules + majuscules;
                        break;
                    }
                case 3:
                    {
                        alphabet = minuscules + majuscules + chiffres;
                        break;
                    }
                case 4:
                    {
                        alphabet = minuscules + majuscules + chiffres + caractereSpeciaux;
                        break;
                    }
                default:
                    {
                        alphabet = minuscules;
                        break;     
                    }
            }

            
            
            string password = GenPassword(alphabet, longeurPassword);
            Console.WriteLine(password);

        }
    }
}


