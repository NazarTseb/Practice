using System;
using System.Collections.Generic;
using System.Linq;



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
