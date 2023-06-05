using System;
using Course.Entities;

namespace Course
{
    class Program
    {
    static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Annie", 500.00);
            Account acc2 = new BusinessAccount(1002, "Alexey", 255.00, 0.1);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

            acc2.Deposit(550.25);

            Console.WriteLine(acc2);
        }
    }
}