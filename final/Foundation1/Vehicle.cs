public class Vehicle
{
    private string _vin;
    private string _make;
    private string _model;
    private int _year;
    private int _mileage;

    public Vehicle(string vin, string make, string model, int year, int mileage)
    {
        _vin = vin;
        _make = make;
        _model = model;
        _year = year;
        _mileage = mileage;
    }

    public string Vin
    {
        get { return _vin; }
        set { _vin = value; }
    }

    public string Make
    {
        get { return _make; }
        set { _make = value; }
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }

    public int Mileage
    {
        get { return _mileage; }
        set { _mileage = value; }
    }
}
