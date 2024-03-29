﻿namespace Course.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime end, Vehicle vehicle, Invoice invoice)
        {
            Start = start;
            End = end;
            Vehicle = vehicle;
            Invoice = null;
        }   
    }
}
