using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta on eesnimi:");
            string userName = Console.ReadLine();

            GetUserNameData(userName);
        }

        private static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sumbolit pikk");
            Console.WriteLine($"Sinu eesnime esimene taht on {userInput[0]}");

            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userInput[i]);
            }
        }
    }
}
