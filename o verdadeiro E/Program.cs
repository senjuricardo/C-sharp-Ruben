using System;

namespace o_verdadeiro_E
{
    class Program
    {



        static void Main(string[] args)
        {
            string n;




            Console.WriteLine("Introduza o tamanho do vetor");
            n = Console.ReadLine();



            string[] vec = new string[int.Parse(n)];



            bool teste = vetorString(vec, n);




            if (teste == true)
            {
                Console.WriteLine("Tem todos o mesmo tamanho!");
            }
            else
            {
                Console.WriteLine("Há elementos com tamanho diferente");
            }
        }



        private static bool vetorString(string[] vec, string n)
        {



            for (int i = 0; i < int.Parse(n); i++)
            {
                Console.WriteLine("Introduza o seu nome");
                vec[i] = Console.ReadLine();
            }



            for (int i = 0; i < int.Parse(n); i++)
            {
                int igual = vec[0].Length;



                if (vec[i].Length != igual)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
