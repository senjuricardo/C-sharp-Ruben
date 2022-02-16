using System;
using System.IO;
namespace EXER_2__PL2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader("D:\\NOTAS.txt");
            StreamWriter wd = new StreamWriter("D:\\APROVADOS.txt");
            StreamWriter wd40 = new StreamWriter("D:\\REPROVADOS.txt");

            while(!rd.EndOfStream){
                string linha = rd.ReadLine();
                string[] palavras = linha.Split(' ');

                    if (double.Parse(palavras[2]) >= 9.5)
                    {
                        wd.WriteLine(linha);
                    }
                    else
                    {
                        wd40.WriteLine(linha);
                    }                     
            }
            rd.Close();
            wd.Close();
            wd40.Close();

        }

      
    }
    
}
