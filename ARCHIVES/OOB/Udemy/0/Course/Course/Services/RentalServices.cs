using Course.Entities;

namespace Course.Services
{
    internal class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ItaxServices _taxService;

        public RentalServices (double pricePerHour, double pricePerDay, ItaxServices taxService)
        {
            _taxService = taxService;
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalSeconds <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double taxService = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice (basicPayment, taxService);
        }
    }
}
