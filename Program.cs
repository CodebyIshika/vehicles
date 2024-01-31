using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //car info
            Vehicle carObj1 = new Car(1, "Honda", "Accord", 2021, 45.0, 4);
            RentalAgency.AddVehicle(carObj1);

            // truck info
            Vehicle truckObj1 = new Truck(2, "Zeta", "F-150", 2013, 60.0, 200);
            RentalAgency.AddVehicle(truckObj1);

            CarRental carRental = new CarRental(101, DateTime.Now, DateTime.Now.AddDays(10), "Joey Ford");
            carRental.ActualReturnDate = DateTime.Now.AddDays(10); 
            RentalAgency.RentCar(carRental);
            Console.WriteLine("");
            // Rent a truck
            TruckRental truckRental = new TruckRental(102, DateTime.Now, DateTime.Now.AddDays(5), "James Bond");
            truckRental.ActualReturnDate = DateTime.Now.AddDays(5); 
            RentalAgency.RentTruck(truckRental);

            // display rental history
            RentalAgency.DisplayRentalHistory();
            
            Console.ReadKey();

        }
    }
}
