namespace PersonDevices;

public class Person
{
    private const int MaxNumberOfDevices = 2;
    private string _id;
    private string _fullName;
    private Cellphone?[] _cellphones;
    private int _numberOfCellsphones;
    
    public Person()
    {
        _id = "invalid id";
        _fullName = "invalid name";
        _cellphones = new Cellphone?[MaxNumberOfDevices];
        _numberOfCellsphones = 0;
    }

    public Person(string id, string fullName)
    {
        _id = id;
        _fullName = fullName;
        _cellphones = new Cellphone?[MaxNumberOfDevices];
        _numberOfCellsphones = 0;
    }
    
    public string Id {get => _id; set => _id = value; }
    public string FullName {get => _fullName; set => _fullName = value; }

    public Cellphone AddCellphone(string imei, string cellphoneNumber)
    {
        if (_numberOfCellsphones >= MaxNumberOfDevices)
            throw new ArgumentOutOfRangeException(nameof(_numberOfCellsphones), "Only two devices are supported.");

        var newCellphone = new Cellphone(imei, cellphoneNumber, this );
        _cellphones[_numberOfCellsphones++] = newCellphone;
        return newCellphone;
    }

    public Cellphone GetPhone(int index)
    {
        if (index < 0 || index >= _numberOfCellsphones)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        return _cellphones[index]!;
    }


}