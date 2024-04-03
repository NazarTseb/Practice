using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string FuelType { get; set; }
    public double FuelConsumption { get; set; } 
    public int Speed { get; set; } 

    public Car(string brand, string model, string fuelType, double fuelConsumption, int speed)
    {
        Brand = brand;
        Model = model;
        FuelType = fuelType;
        FuelConsumption = fuelConsumption;
        Speed = speed;
    }

    public override string ToString()
    {
        return $"{Brand} {Model} ({FuelType}) - Fuel Consumption: {FuelConsumption} L/100km, Max Speed: {Speed} km/h";
    }
}

class Sedan : Car
{
    public int TrunkCapacity { get; set; } 

    public Sedan(string brand, string model, string fuelType, double fuelConsumption, int speed, int trunkCapacity)
        : base(brand, model, fuelType, fuelConsumption, speed)
    {
        TrunkCapacity = trunkCapacity;
    }

    public override string ToString()
    {
        return base.ToString() + $", Trunk Capacity: {TrunkCapacity} liters";
    }
}

class SUV : Car
{
    public int TowingCapacity { get; set; } 

    public SUV(string brand, string model, string fuelType, double fuelConsumption, int speed, int towingCapacity)
        : base(brand, model, fuelType, fuelConsumption, speed)
    {
        TowingCapacity = towingCapacity;
    }

    public override string ToString()
    {
        return base.ToString() + $", Towing Capacity: {TowingCapacity} kg";
    }
}

class TaxiPark
{
    private List<Car> cars;

    public TaxiPark(List<Car> cars)
    {
        this.cars = cars;
    }

    public double CalculateFleetCost()
    {
        return cars.Count * 20000;
    }

    public List<Car> SortByFuelConsumption()
    {
        return cars.OrderBy(car => car.FuelConsumption).ToList();
    }

    public List<Car> FindCarsInSpeedRange(int minSpeed, int maxSpeed)
    {
        return cars.Where(car => car.Speed >= minSpeed && car.Speed <= maxSpeed).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var car1 = new Sedan("Toyota", "Camry", "Petrol", 8, 180, 500);
        var car2 = new SUV("Ford", "Explorer", "Diesel", 10, 170, 2000);
        var car3 = new Sedan("Honda", "Accord", "Petrol", 7, 200, 450);
        var car4 = new SUV("Jeep", "Grand Cherokee", "Petrol", 12, 160, 2500);

        var taxiPark = new TaxiPark(new List<Car> { car1, car2, car3, car4 });

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Calculate fleet cost");
            Console.WriteLine("2. Sort cars by fuel consumption");
            Console.WriteLine("3. Find cars in speed range");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    double cost = taxiPark.CalculateFleetCost();
                    Console.WriteLine($"The total cost of the fleet is ${cost}");
                    break;

                case "2":
                    List<Car> sortedCars = taxiPark.SortByFuelConsumption();
                    Console.WriteLine("Cars sorted by fuel consumption:");
                    foreach (var car in sortedCars)
                    {
                        Console.WriteLine(car);
                    }
                    break;

                case "3":
                    Console.Write("Enter minimum speed: ");
                    int minSpeed = int.Parse(Console.ReadLine());
                    Console.Write("Enter maximum speed: ");
                    int maxSpeed = int.Parse(Console.ReadLine());
                    List<Car> carsInSpeedRange = taxiPark.FindCarsInSpeedRange(minSpeed, maxSpeed);
                    Console.WriteLine($"Cars in speed range {minSpeed}-{maxSpeed} km/h:");
                    foreach (var car in carsInSpeedRange)
                    {
                        Console.WriteLine(car);
                    }
                    break;

                case "4":                    
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}
