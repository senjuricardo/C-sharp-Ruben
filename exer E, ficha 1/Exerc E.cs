using System;

namespace exer_E__ficha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3;

            Console.WriteLine("digite o nome 1");
            nome1 = Console.ReadLine();
            Console.WriteLine("digite o nome 2");
            nome2 =Console.ReadLine();
            Console.WriteLine("digite o nome 3");
            nome3 =Console.ReadLine();

            maior(nome1, nome2, nome3);
        }

        private static void maior(string nome1, string nome2, string nome3)
        {
            if(nome1.Length > nome2.Length && nome1.Length >nome3.Length)
            {
                Console.WriteLine(nome1);
            }
            if (nome2.Length > nome1.Length && nome2.Length > nome3.Length)
            {
                Console.WriteLine(nome2);
            }
            if (nome3.Length > nome1.Length && nome3.Length > nome2.Length)
            {
                Console.WriteLine(nome3);
            }
        }
    }
}
