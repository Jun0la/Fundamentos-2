using System;
using System.Globalization;

namespace Test 
{
class Basics_5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double [n];

            for (int i = 0;  i< n;  i++) 
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            }

            double sum = 0.0;

            for (int i =0; i< n; i++) 
            {
                sum += vect[i];
            }

            double avg = sum / n;   

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }

        /*
         static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto [n];

            for (int i = 0 ; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto { Name= name,  Price = price }; 
            }

                double sum = 0.0;

            for (int i = 0; i < n; i++) 
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine( "Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
        */

            string[] vect = new string[] { "Marry", "Bob", "Alex" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
    }
}