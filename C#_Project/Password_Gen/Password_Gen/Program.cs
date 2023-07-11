using System;
using FormationCS;

namespace Password_Gen
{

    class Program
    {

        static void Main(string[] args)
        {


            int longeurPassword = outils.DemanderNombrePositifNonNul("Longeur du mot de passe ? : ");
            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caractereSpeciaux = "+*%&/()=?`^,.@#€";
            string alphabet;
            const int NOMBREPASSWORD = 10;

            int reponse = outils.DemanderNombreEntre("Quel caractère dois contenir le mot de passe; \n" +
                "1 - Uniquement des caractère en minuscule \n2 - Des caractère minuscule et majuscule \n" +
                "3 - Des caractère et des chiffres \n4 - Caractères, chiffres et caractères spéciaux \n" +
                "Votre choix : ", 1, 4);
            Console.WriteLine();
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

            Console.WriteLine("_-_-_-_-_-_-_-_");
            for (int i = 0; i < NOMBREPASSWORD; i++)
            {
                string password = outils.GenPassword(alphabet, longeurPassword);
                Console.WriteLine("Password N°" + (i + 1) + ": " + password);
            }
            Console.WriteLine("-_-_-_-_-_-_-_-");

            //int pattern = 1;
            //string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmonpqrstuvwxyz0123456789";
            //for (int i = 0; i < 10; i++)
            //{
            //    string password1 = outils.GenPassword(alphabet, 4, pattern);
            //    string password2 = outils.GenPassword(alphabet, 4, pattern);
            //    string password3 = outils.GenPassword(alphabet, 4, pattern);
            //    string password4 = outils.GenPassword(alphabet, 4, pattern);
            //    string key = password1 + "-" + password2 + "-" + password3 + "-" + password4;
            //    Console.WriteLine("Password N°" + (i + 1) + ": " + key);
            //}

        }
    }
}


