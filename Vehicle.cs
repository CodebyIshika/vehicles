using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLab03
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double RentalRate {  get; set; }

        // Constructor to initialize vehicle properties
        public Vehicle(int vehicleId, string make, string model, int year, double rentalRate)
        {
            this.VehicleId = vehicleId;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.RentalRate = rentalRate;
        }

        // display information about the vehicle
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Vehicle ID: {VehicleId}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Rate: ${RentalRate:F2}");
        }

    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(int vehicleId, string make, string model, int year, double rentalRate, int numberOfDoors)
            : base(vehicleId, make, model, year, rentalRate)
        {
            NumberOfDoors = numberOfDoors;
        }


        // Override method to display car information, including the number of doors
        public new void DisplayCarInfo()
        {
            // the base method to display common vehicle information
            base.DisplayCarInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }

    }

    public class Truck : Vehicle
    {
        public int CargoCapacity { get; set; }

        public Truck(int vehicleId, string make, string model, int year, double rentalRate, int cargoCapacity)
            : base(vehicleId, make, model, year, rentalRate)
        {
            CargoCapacity = cargoCapacity;
        }

        // Override method to display truck information, including the cargo capacity
        public new void DisplayCarInfo()
        {
            // the base method to display common vehicle information
            base.DisplayCarInfo();
            Console.WriteLine($"Cargo Capacity: {CargoCapacity} cubic feet");
        }
    }
}
