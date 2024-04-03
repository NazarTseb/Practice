using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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