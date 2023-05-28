public class Truck : Vehicle
{
    private int _numDoors;
    private string _truckType;

    public Truck(string vin, string make, string model, int year, int mileage, int numDoors, string truckType)
        : base(vin, make, model, year, mileage)
    {
        _numDoors = numDoors;
        _truckType = truckType;
    }

    public int NumDoors
    {
        get { return _numDoors; }
        set { _numDoors = value; }
    }

    public string TruckType
    {
        get { return _truckType; }
        set { _truckType = value; }
    }
}
