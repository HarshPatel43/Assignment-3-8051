using System;

public class RentalAgency
{
    private Vehicle[] fleet;
    private double totalRevenue;

    public RentalAgency(int fleetSize)
    {
        fleet = new Vehicle[fleetSize];
    }

    public double TotalRevenue
    {
        get { return totalRevenue; }
    }

    public void AddVehicle(Vehicle vehicle, int index)
    {
        fleet[index] = vehicle;
    }

    public void RemoveVehicle(int index)
    {
        fleet[index] = null;
    }

    public void RentVehicle(int index)
    {
        if (fleet[index] != null)
        {
            totalRevenue += fleet[index].RentalPrice;
            fleet[index] = null;
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }
}
