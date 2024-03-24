using System;

class Program
{
    static void Main(string[] args)
    {
        RentalAgency agency = new RentalAgency(10);

        Car car = new Car
        {
            Model = "Corolla",
            Manufacturer = "Toyota",
            Year = 2022,
            RentalPrice = 50.0,
            Seats = 5,
            EngineType = "Petrol",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "F-150",
            Manufacturer = "Ford",
            Year = 2020,
            RentalPrice = 100.0,
            Capacity = 4,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        agency.AddVehicle(car, 0);
        agency.AddVehicle(truck, 1);

        agency.RentVehicle(0);
        agency.RentVehicle(1);

        Console.WriteLine($"Total revenue: {agency.TotalRevenue}");

        // Displaying details of vehicles in fleet
        foreach (var vehicle in agency.Fleet)
        {
            if (vehicle != null)
            {
                vehicle.DisplayDetails();
            }
        }
    }
}
