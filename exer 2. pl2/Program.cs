using System;

using System.IO;

namespace exer_2._pl2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader("D:\\VENCIMENTOS.txt");
            StreamWriter wd = new StreamWriter("D:\\SUPMIL.txt");

            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] words = linha.Split(' ');

               /* foreach (var word in words)
                {
                    System.Console.WriteLine($"<{word}>");
                
                }*/
               if(int.Parse(words[2]) > 1000)
                {
                    wd.WriteLine(linha);
                }
            
            }
            rd.Close();
            wd.Close();


        }
    }
}
