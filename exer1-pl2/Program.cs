using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exer1_pl2
{
    class Program
    {
        static void Main(string[] args)
        {
          
           StreamReader rd = new StreamReader("D:\\VENCIMENTOS.txt");
            
            List<string> list = File.ReadAllLines("D:\\VENCIMENTOS.txt").ToList();

            List<string> maiorMil = greaterThan(list, 1000);

            if(maiorMil != null)
            {
               StreamWriter wr = new StreamWriter("D:\\SUPMIL.txt");
                foreach(string linha in maiorMil)
                {
                    wr.WriteLine(linha);
                    Console.WriteLine(linha);
                }
                wr.Close();
            }

        }
        public static List<string> greaterThan(List<string> lines, int value)
        {
            List<string> result = new List<string>();
            foreach (string line in lines)
            {
                string[] items = line.Split(' ');
                if (int.Parse(items[2]) > value)
                    result.Add(line);
            }
            return result;
        }
    }
}
