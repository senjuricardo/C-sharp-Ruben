using System;

namespace exer_H___pl1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("digite o nome");
            n = Console.ReadLine();

            bool verif = AreDigitsOnly(n);
            Console.WriteLine(verif);
        }

        public static bool AreDigitsOnly(string text)
        {


            foreach (char character in text)
            {
                if (character < 'a' || character > 'z')
                    return false;
            }

            return true;
        }

    }
}