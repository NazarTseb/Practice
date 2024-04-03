using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
