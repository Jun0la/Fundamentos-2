using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Enter rental data");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup: ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return: ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));



            RentalServices rentalServices = new RentalServices(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalServices.ProcessInvoice(carRental);
            Console.WriteLine(carRental.Invoice);

        }
    }
}