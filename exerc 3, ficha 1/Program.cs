string? nome;
Console.WriteLine("digite o nome");
nome = Console.ReadLine();

string parte = nome.Substring(nome.Length - 2, 2);
if (parte == "eu")
    Console.WriteLine("ola :" + nome + " da ca o meu!");
else
{
    Console.WriteLine("ola :" + nome);
}