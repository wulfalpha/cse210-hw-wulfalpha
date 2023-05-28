public class Car : Vehicle
{
    private int _numDoors;

    public Car(string vin, string make, string model, int year, int mileage, int numDoors)
        : base(vin, make, model, year, mileage)
    {
        _numDoors = numDoors;
    }

    public int NumDoors
    {
        get { return _numDoors; }
        set { _numDoors = value; }
    }
}
