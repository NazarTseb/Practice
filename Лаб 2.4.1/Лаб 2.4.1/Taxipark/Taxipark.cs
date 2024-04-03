using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
