using System;
using System.Data;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(1998, 1, 21, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "good morning folkz";

            Console.WriteLine(s1.Cut(10));
        }
    }
}