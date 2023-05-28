using System;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle("1HGCM82633A123456", "Honda", "Accord", 2023, 0);
        Vehicle vehicle2 = new Vehicle("1HGCM82633A123457", "Toyota", "Camry", 2023, 0);

        Car car1 = new Car("1HGCM82633A123458", "BMW", "Series 3", 2023, 0, 4);

        Truck truck1 = new Truck("1HGCM82633A123459", "Ford", "F-150", 2023, 0, 2, "Pickup");
        Truck truck2 = new Truck("1HGCM82633A123460", "Chevrolet", "Silverado", 2023, 0, 4, "Pickup");

        Console.WriteLine($"Vehicle 1 VIN: {vehicle1.Vin}, Make: {vehicle1.Make}, Model: {vehicle1.Model}, Year: {vehicle1.Year}, Mileage: {vehicle1.Mileage}");
        Console.WriteLine($"Vehicle 2 VIN: {vehicle2.Vin}, Make: {vehicle2.Make}, Model: {vehicle2.Model}, Year: {vehicle2.Year}, Mileage: {vehicle2.Mileage}");

        Console.WriteLine($"Car 1 VIN: {car1.Vin}, Make: {car1.Make}, Model: {car1.Model}, Year: {car1.Year}, Mileage: {car1.Mileage}, Number of doors: {car1.NumDoors}");

        Console.WriteLine($"Truck 1 VIN: {truck1.Vin}, Make: {truck1.Make}, Model: {truck1.Model}, Year: {truck1.Year}, Mileage: {truck1.Mileage}, Number of doors: {truck1.NumDoors}, Type: {truck1.TruckType}");
        Console.WriteLine($"Truck 2 VIN: {truck2.Vin}, Make: {truck2.Make}, Model: {truck2.Model}, Year: {truck2.Year}, Mileage: {truck2.Mileage}, Number of doors: {truck2.NumDoors}, Type: {truck2.TruckType}");
    }
}
