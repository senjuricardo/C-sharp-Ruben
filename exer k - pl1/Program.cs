using System;

namespace exer_g__fich1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] vec = new string[3];
            vetorOrdenado(vec);
        }

        private static void vetorOrdenado(string[] vec)
        {
          
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("digite o nome");
                vec[i] = Console.ReadLine();        
            }

            for(int i=0; i<3; i++)
            {
                Array.Sort(vec, StringComparer.InvariantCulture); 
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(vec[i]);
            }
        }
    }
}
