using System;

namespace exer_H___pl1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, n2;
            Console.WriteLine("digite o nome 1");
            n = Console.ReadLine();
            Console.WriteLine("digite o nome 2");
            n2 = Console.ReadLine();

           int maio = maior(n, n2);
            if(maio < 0) { 
            Console.WriteLine("o primeiro é: "+n);
            }
            else
            {
                Console.WriteLine("o primeiro é: " + n2);
            }
        }

        public static int maior(string text, string text2)
        { int cont = 0;
            int valor;
            do
            {
                valor = text[cont].CompareTo(text2[cont]);
                cont++;
            } while (valor == 0);
            return valor;
        }

    }
}