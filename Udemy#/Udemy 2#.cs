using System;
using System.Globalization;


namespace TASK
{
    class Basics_2
    {
        
    static void Main()
        
        {   
            System.Console.WriteLine("Quantos numeros inteiros: ");
               
            int N = int.Parse(Console.ReadLine());
            
            int soma = 0;

            for (int i = 1; i <= N; i++)
               
            {
                System.Console.Write("Valor  #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            System.Console.WriteLine("Soma = " + soma);

            //---------------------------------------------------------------------//

            System.Console.WriteLine("Digite um numero: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            
            {

            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("Digite outro numero: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            }

            System.Console.WriteLine("Numero Negativo");

            /*
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            // double resultado = Maior (n1, n2, n3);

            // System.Console.WriteLine("Maior = " +resultado);
            */
        }


    static int Maior (int a, int b, int c)

        {
            int M;

            if (a > b && a > c)

                {M = a;}

            else if (b > c)

                {M = b; }

            else { M = c; } 

            return M;  
        }

    }
}
