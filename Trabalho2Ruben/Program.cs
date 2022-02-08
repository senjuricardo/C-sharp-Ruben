using System;
namespace Trabalho2Ruben;


class Program
{
    static void Main(string[] args)
    {

        string n1, n2;
        int soma;

        Console.WriteLine("digite o n1");
        n1 = Console.ReadLine();

        Console.WriteLine("digite o n2");
        n2 = Console.ReadLine();

        soma =  int.Parse(n1) + int.Parse(n2);

        Console.WriteLine("soma: " + soma);

        System.Threading.Thread.Sleep(3000);
    }


}