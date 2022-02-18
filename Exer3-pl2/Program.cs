using System;
using System.IO;
using System.Collections.Generic;

namespace Exer3_pl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            // LER OS PRODUTOS, COMPRAS E CLIENTES
             StreamReader rd = new StreamReader("C:\\produtos.csv");

            string[] palavrasProd;
            while (!rd.EndOfStream)
            {
                string linhaProd = rd.ReadLine();
                palavrasProd = linhaProd.Split(';');
                Console.WriteLine(linhaProd);   
                
             }
            Console.WriteLine("-------------------------");

           StreamReader rd2 = new StreamReader("C:\\compras.csv");
            List<string> palavrasCompra = new List<string>();
            while (!rd2.EndOfStream)
            {
                string linhaCompra = rd2.ReadLine();
                palavrasCompra.Add(linhaCompra.Split(';'));
                Console.WriteLine(linhaCompra); 
            }
            Console.WriteLine("-------------------------");

            StreamReader rd3 = new StreamReader("C:\\clientes.csv");
            string[] palavrasCliente = new string[5];
            int i = 0;
            while (!rd3.EndOfStream)
            {
                string linhaClientes = rd3.ReadLine();
                palavrasCliente[i] = linhaClientes.Split(';');
                Console.WriteLine(linhaClientes);
                i++;
            }
            Console.WriteLine("-------------------------");
            string teste = palavrasCliente[1];
            Console.WriteLine(palavrasCliente[1]);
             /*StreamWriter wr = new StreamWriter("C:\\bird.txt", true);
            // MERDA DAQUI PARA BAIXO
            
            while (flag == 0)
            {
                Console.WriteLine("hello world");
                string linhaProd = rd.ReadLine();
                string[] palavrasProd = linhaProd.Split(';');
                string linhaCompra = rd2.ReadLine();
                string[] palavrasCompra = linhaCompra.Split(';');
                string linhaClientes = rd3.ReadLine();
                string[] palavrasCliente = linhaClientes.Split(';');
                int total = 0;
                wr.WriteLine("O VALOR TOTAL PAGO PELO ALBINO E Deeeee");
                if (int.Parse(palavrasCompra[0]) == 1)
                {
                    if(palavrasProd[1] == palavrasCompra[0]) {
                        total = total + int.Parse(palavrasProd[4]);
                      //  wr.WriteLine("O VALOR TOTAL PAGO PELO ALBINO E DE: "+total);
                    }
                    
                }
                flag = 1;
            }*/
           // wr.Close();
            rd.Close();
            rd2.Close();
            rd3.Close();


        }
    }
}

