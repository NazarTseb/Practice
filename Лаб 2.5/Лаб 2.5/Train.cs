class Train : Transport
{
    public int Beds {  get; set; }
    public Train(string type, int passengerCapacity, double cargoCapacity, int price, int speed)
        : base(type, passengerCapacity, cargoCapacity, price, speed)
    {
    }
    public override double CalculatePassengerTime()
    {
        return 100 / Speed;
    }

    public override double CalculateCargoTime()
    {
        return 100 / Speed;
    }

    public override double CalculatePassengerCost()
    {
        return PassengersAmmount * Price;
    }

    public override double CalculateCargoCost()
    {
        return CargoCapacity * Price;
    }
}