public class SUV : Vehicle
{
    private int _numDoors;
    private int _numPassengers;

    public SUV(string vin, string make, string model, int year, int mileage, int numDoors, int numPassengers)
        : base(vin, make, model, year, mileage)
    {
        _numDoors = numDoors;
        _numPassengers = numPassengers;
    }

    public int NumDoors
    {
        get { return _numDoors; }
        set { _numDoors = value; }
    }

    public int NumPassengers
    {
        get { return _numPassengers; }
        set { _numPassengers = value; }
    }
}
