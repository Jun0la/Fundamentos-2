﻿using System;
using System.Collections.Generic;
using Course.Entities;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter full file patch");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = Double.Parse(fields[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
           
            Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}