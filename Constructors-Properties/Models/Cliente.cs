using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Constructors_Properties.Models
{
    public class Cliente
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Cliente()
        {

        }
        public Cliente(int numeroConta, string nome, double saldo)
        {
           NumeroConta = numeroConta;
           Nome = nome;
           Saldo = saldo;
        }
        public Cliente(int numeroConta, string nome)
        {   
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = 0;
        }

        public void Depositar(double deposito) 
        {
            Saldo += deposito;
            Console.WriteLine("p");
        }


        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }

}