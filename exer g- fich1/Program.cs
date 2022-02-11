using System;

namespace exer_g__fich1
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("digite o tamanho do vetor");
            n = Console.ReadLine();

            string[] vec = new string[int.Parse(n)];
            trocaLetra(vec, n);
        }

        private static void trocaLetra(string[] vec, string n)
        {
            for (int i = 0; i < int.Parse(n); i++)
            {
                Console.WriteLine("digite o nome");
                vec[i] = Console.ReadLine();
                vec[i] = vec[i].Replace('v', 'b');
            }
            for (int i = 0; i < int.Parse(n); i++)
            {
                Console.WriteLine(vec[i]);
            }
        }
    }
}
        
    

