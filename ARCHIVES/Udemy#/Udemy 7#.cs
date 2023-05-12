using System;

namespace Test
{
    class Test
    {
        static void Main(String[] args)
        {
            int x  = int.Parse(Console.ReadLine());

            string day;

            switch (x)
            {
                case 1: day = "Sunday";
                   break;
                case 2: day = "Monday";
                    break;
                case 3: day = "Thursday";
                    break;
                default: day = "Invalid Data";
                    break;
            }
            Console.WriteLine("Dia: " + day);
        }

        // if ternário

        /*
         double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            Console.WriteLine(desconto);
        */    
    }
}