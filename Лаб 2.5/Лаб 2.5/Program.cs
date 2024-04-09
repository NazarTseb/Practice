using System;

class Program
{
    static void Main(string[] args)
    {
        Auto motorcycle = new Auto("Motorcycle", 2, 30, 80, 50);
        Bicycle bicycle = new Bicycle("Bicycle", 1, 10, 15, 20);
        Moped moped = new Moped("Moped", 1, 20, 70, 40);
        Auto auto = new Auto("Auto", 4, 40, 90, 60);
        Train train = new Train("Train", 100, 1000, 100, 55);

        Console.WriteLine("Motorcycle:");
        Console.WriteLine(motorcycle);
        Console.WriteLine($"Passenger Time: {motorcycle.CalculatePassengerTime()} hours");
        Console.WriteLine($"Cargo Time: {motorcycle.CalculateCargoTime()} hours");
        Console.WriteLine($"Passenger Cost: ${motorcycle.CalculatePassengerCost()}");
        Console.WriteLine($"Cargo Cost: ${motorcycle.CalculateCargoCost()}");

        Console.WriteLine();

        Console.WriteLine("Bicycle:");
        Console.WriteLine(bicycle);
        Console.WriteLine($"Passenger Time: {bicycle.CalculatePassengerTime()} hours");
        Console.WriteLine($"Cargo Time: {bicycle.CalculateCargoTime()} hours");
        Console.WriteLine($"Passenger Cost: ${bicycle.CalculatePassengerCost()}");
        Console.WriteLine($"Cargo Cost: ${bicycle.CalculateCargoCost()}");

        Console.WriteLine();

        Console.WriteLine("Moped:");
        Console.WriteLine(moped);
        Console.WriteLine($"Passenger Time: {moped.CalculatePassengerTime()} hours");
        Console.WriteLine($"Cargo Time: {moped.CalculateCargoTime()} hours");
        Console.WriteLine($"Passenger Cost: ${moped.CalculatePassengerCost()}");
        Console.WriteLine($"Cargo Cost: ${moped.CalculateCargoCost()}");

        Console.WriteLine();

        Console.WriteLine("Auto:");
        Console.WriteLine(auto);
        Console.WriteLine($"Passenger Time: {auto.CalculatePassengerTime()} hours");
        Console.WriteLine($"Cargo Time: {auto.CalculateCargoTime()} hours");
        Console.WriteLine($"Passenger Cost: ${auto.CalculatePassengerCost()}");
        Console.WriteLine($"Cargo Cost: ${auto.CalculateCargoCost()}");

        Console.WriteLine();

        Console.WriteLine("Train:");
        Console.WriteLine(train);
        Console.WriteLine($"Passenger Time: {train.CalculatePassengerTime()} hours");
        Console.WriteLine($"Cargo Time: {train.CalculateCargoTime()} hours");
        Console.WriteLine($"Passenger Cost: ${train.CalculatePassengerCost()}");
        Console.WriteLine($"Cargo Cost: ${train.CalculateCargoCost()}");
    }
}
