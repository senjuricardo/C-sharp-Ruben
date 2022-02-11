using System;

namespace exer_m__pl1
{
    class Program
    {
        static void Main(string[] args)
        { string palavra;
            Console.WriteLine("Digite uma palvra");
             palavra = Console.ReadLine();

           string novaP = reverse(palavra);
            if(palavra == novaP)
            {
                Console.WriteLine("sao um polindromo");
            }
            else
            {
                Console.WriteLine("Nao sao!");
            }

        }

        private static string reverse(string palavra)
        {
            char[] charArray = palavra.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

            
        }
    }
}
