using System;

namespace exer_F__pl1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("indique o tamanho do vetor");
            n = Console.ReadLine();

            string[] vec = new string[int.Parse(n)];

           int numTotal = funcMaior(vec, n);

            Console.WriteLine("o total de comprimento é: " + numTotal);

        }

        private static int funcMaior(string[] vec, string n)
        {
            int maior = 0;
            for(int i=0; i<int.Parse(n); i++)
            {
                Console.WriteLine("digite o nome");
                vec[i] = Console.ReadLine();
                maior = maior + vec[i].Length;


            }
            return maior;
        }
    }
}
