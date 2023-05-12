using System;
using System.Globalization;
using UdemyOrientacaoObject;

namespace TASK
{
    class Basics_2
    {
        static void Main()

        {
            /*
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            */

            Produto p = new Produto("TV", 500.25, 10);

            p.Nome = "TV 4K";

            Console.WriteLine( p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            /*
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados" + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser REMOVIDO: ");
            qte = int.Parse(Console.ReadLine());
           
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados" + p);       
            */
        }
    }
}