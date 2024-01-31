using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab03
{
    public static class RentalAgency
    {

        private static List<Vehicle> vehiclesList = new List<Vehicle>();
        private static List<CarRental> carRentalList = new List<CarRental>();
        private static List<TruckRental> truckRentalList = new List<TruckRental>();

        // Static method to add vehicles to the agency
        public static void AddVehicle(Vehicle vehicle)
        {
            vehiclesList.Add(vehicle);
        }

        // Static method to process a car rental
        public static void RentCar(CarRental carRental)
        {
            carRentalList.Add(carRental);
        }

        // Static method to process a truck rental
        public static void RentTruck(TruckRental truckRental)
        {
            truckRentalList.Add(truckRental);
        }

        // Static method to display rental history
        public static void DisplayRentalHistory()
        {
            Console.WriteLine("Vehicle Rentals History:");
            Console.WriteLine("");
            Console.WriteLine("Cars:");

            foreach (var carRental in carRentalList)
            {
                Console.WriteLine($"Transaction ID: {carRental.TransactionId}");
                Console.WriteLine($"Customer: {carRental.CustomerName}");
                Console.WriteLine($"Rental Start Date: {carRental.RentalStartDate}");
                Console.WriteLine($"Rental End Date: {carRental.RentalEndDate}");
                Console.WriteLine($"Total Rental Cost: ${carRental.CalculateRentalCost():F2}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Trucks:");

            foreach (var truckRental in truckRentalList)
            {
                Console.WriteLine($"Transaction ID: {truckRental.TransactionId}");
                Console.WriteLine($"Customer: {truckRental.CustomerName}");
                Console.WriteLine($"Rental Start Date: {truckRental.RentalStartDate}");
                Console.WriteLine($"Rental End Date: {truckRental.RentalEndDate}");
                Console.WriteLine($"Total Rental Cost: ${truckRental.CalculateRentalCost():F2}");
            }
        }


    }
}
