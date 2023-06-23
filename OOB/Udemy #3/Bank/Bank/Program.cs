using System;
using System.Globalization;

namespace Bank 
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o tiular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N): ");
            Char resp = char.Parse(Console.ReadLine());
           
            if (resp == 's' || resp == 'S') 
            {
                Console.WriteLine("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine( "Dados da conta atualizados: ");
            Console.WriteLine( conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta ATUALIZADOS!");
            Console.WriteLine( conta);  
            
            Console.ReadKey();
        }
    }
}