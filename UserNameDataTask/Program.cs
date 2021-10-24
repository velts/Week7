using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();


            Console.WriteLine("Vali number 1-3 vahel");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    ReverseName(userName);
                    break;
                case 2:
                    UserNameFirstLetter(userName);
                    break;
                case 3:
                    UserNameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena paeva!");
                    break;


            }
        }
        private static void ReverseName(string userName)
        {
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Sinu nimi on tagurpidi{userName[i]}");
            }
        }
        private static void UserNameFirstLetter(string userName)
        {
            Console.WriteLine($"Sinu eesnime esimene taht on {userName[0]}");
        }
        private static void UserNameLength(string userName)
        {
            Console.WriteLine($"Sinu nimi on {userName.Length} sumbolit pikk");
        }
    }
}
