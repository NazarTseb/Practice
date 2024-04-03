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


