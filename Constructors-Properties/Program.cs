using Constructors_Properties.Models;
using System.Globalization;

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
    Cliente c1 = new Cliente(conta, nome);
}