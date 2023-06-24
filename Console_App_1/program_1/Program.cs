namespace Program_1
{
    class Program
    {

        static void AfficherInfosPersonne(string nom, int age)
        {
            Console.WriteLine();
            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age + " ans");
            Console.WriteLine("bientôt vous aurez " + (age+1) + " ans");

            
            if (age == 17)
            {
                Console.WriteLine("Vous serez bientôt majeur");
            }
            else if (age == 18) 
            {
                Console.WriteLine("Vous êtes tout juste majeur, félicitation");
            }
            else if (age >= 18 && age < 60)
            {
                Console.WriteLine("Vous êtes majeurs");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Vous êtes sénior");
            }
            else if (age <= 10)
            {
                Console.WriteLine("Vous êtes un enfant");
            }
            else
            {
                Console.WriteLine("Vous etes mineurs");
            }

        }

        static string DemanderNom(int numeroPersonne)
        {
            string nom = "";
            while (nom == "")
            {
                Console.WriteLine("Quel est le nom de la personne numéro " + numeroPersonne + " ? ");
                nom = Console.ReadLine();
                nom = nom.Trim();
                if (nom == "")
                {
                    Console.WriteLine("Erreur: le nom ne doit pas être vide");
                }
            }
            return nom;
        }

        static int DemanderAge(string nom)
        {
            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write(nom + ", Quel est ton age ? ");
                string age_str = Console.ReadLine();
                
                try
                {
                    age_num = int.Parse(age_str);

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur : L'age ne doit pas être egal à 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur : Vous devez rentrer un age valide.");
                }
            }
            return age_num;
        }

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Demander le nom
            //string nom1 = DemanderNom(1);
            //string nom2 = DemanderNom(2);
            string nom1 = "jean";
            string nom2 = "paul";

            // Demander L'age
            int age1 = DemanderAge(nom1);
            int age2 = DemanderAge(nom2);

            // Afficher les information des personne
            AfficherInfosPersonne(nom1, age1);
            AfficherInfosPersonne(nom2, age2);


        }

    }

}






