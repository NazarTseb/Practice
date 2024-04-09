abstract class Transport
{

    public string Type { get; set; }
    public int PassengersAmmount { get; set; }
    public double CargoCapacity { get; set; }
    public int Price { get; set; }
    public int Speed { get; set; }


    public Transport(string type, int passengerCapacity, double cargoCapacity, int price, int speed)
    {
        Type = type;
        PassengersAmmount = passengerCapacity;
        CargoCapacity = cargoCapacity;
        Price = price;
        Speed = speed;

    }


    public abstract double CalculatePassengerTime();
    public abstract double CalculateCargoTime();
    public abstract double CalculatePassengerCost();
    public abstract double CalculateCargoCost();


    public override string ToString()
    {
        return $"Type: {Type}, Passengers ammount: {PassengersAmmount}, Cargo capacity: {CargoCapacity} kg, Speed: {Speed} km/h.";
    }
}