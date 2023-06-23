using System;
using Course.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD", 89.90));

            Action<Product> act = UpdatePrice;

            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(func).ToList();
            foreach (string s in result) 
            {
                Console.WriteLine(s);
            }

            list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            list.RemoveAll(ProductTest);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}