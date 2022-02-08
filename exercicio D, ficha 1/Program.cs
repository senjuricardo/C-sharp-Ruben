string nome;

int i = 0;
int pos = 0;

Console.WriteLine("digite o nome completo");
nome = Console.ReadLine();

string[] palavras = nome.Split(' ');
foreach (string palavra in palavras)
{

    palavras[i] = palavra;
    i++;
    pos++;
}

for (i = 0; i < pos; i++)
{
    Console.WriteLine("ola "+palavras[0] + " "+ palavras[pos-1] );

    System.Threading.Thread.Sleep(3000);
}
