using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter vehicle type (1 for generic Vehicle, 2 for Car, 3 for Truck, 4 for SUV):");
        int vehicleType = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter VIN:");
        string vin = Console.ReadLine();

        Console.WriteLine("Enter Make:");
        string make = Console.ReadLine();

        Console.WriteLine("Enter Model:");
        string model = Console.ReadLine();

        Console.WriteLine("Enter Year:");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Mileage:");
        int mileage = Convert.ToInt32(Console.ReadLine());

        Vehicle vehicle = null;

        switch (vehicleType)
        {
            case 1:
                vehicle = new Vehicle(vin, make, model, year, mileage);
                break;
            case 2:
                Console.WriteLine("Enter number of doors:");
                int carNumDoors = Convert.ToInt32(Console.ReadLine());
                vehicle = new Car(vin, make, model, year, mileage, carNumDoors);
                break;
            case 3:
                Console.WriteLine("Enter number of doors:");
                int truckNumDoors = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Truck Type:");
                string truckType = Console.ReadLine();
                vehicle = new Truck(vin, make, model, year, mileage, truckNumDoors, truckType);
                break;
            case 4:
                Console.WriteLine("Enter number of doors:");
                int suvNumDoors = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of passengers:");
                int numPassengers = Convert.ToInt32(Console.ReadLine());
                vehicle = new SUV(vin, make, model, year, mileage, suvNumDoors, numPassengers);
                break;
        }

        if (vehicle != null)
        {
            Console.WriteLine($"VIN: {vehicle.Vin}, Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}, Mileage: {vehicle.Mileage}");
        }

        // Add two example SUVs
        SUV suv1 = new SUV("1HGCM82633A123461", "Subaru", "Forester", 2023, 0, 5, 7);
        SUV suv2 = new SUV("1HGCM82633A123462", "Toyota", "Highlander", 2023, 0, 5, 8);

        Console.WriteLine($"SUV 1 VIN: {suv1.Vin}, Make: {suv1.Make}, Model: {suv1.Model}, Year: {suv1.Year}, Mileage: {suv1.Mileage}, Number of doors: {suv1.NumDoors}, Number of Passengers: {suv1.NumPassengers}");
        Console.WriteLine($"SUV 2 VIN: {suv2.Vin}, Make: {suv2.Make}, Model: {suv2.Model}, Year: {suv2.Year}, Mileage: {suv2.Mileage}, Number of doors: {suv2.NumDoors}, Number of Passengers: {suv2.NumPassengers}");
    }
}
