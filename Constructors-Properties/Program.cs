using Constructors_Properties.Models;
using System.Globalization;

Cliente c1 = new Cliente();

Console.Write("Entre o número da conta: ");
int conta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string nome = Console.ReadLine();

string operacao;


do
{
    Console.Write("Haverá depósito inicial (s/n)? ");
    operacao = Console.ReadLine().ToLower();

}while(operacao != "s" && operacao != "n");

if(operacao == "s")
{
    Console.Write("Entre o valor de depósito inicial: ");
    double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    c1 = new Cliente(conta, nome, saldo);
}
else 
{
    c1 = new Cliente(conta, nome);
}

Console.WriteLine("Dados da conta:");
Console.WriteLine(c1);