using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
