using System;

namespace CabInvoiceGeneratorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            RideRepository rideRepository = new RideRepository();
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 5) };
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            rideRepository.AddRide("sanju", rides);
            InvoiceSummary invoice = invoiceGenerator.CalculateFare(rideRepository.getRides("sanju"));
            Console.WriteLine(invoice.averageFare);
        }
    }
}
