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

    public void AddCellphone(string imei, string cellphoneNumber)
    {
        if (_numberOfCellsphones < MaxNumberOfDevices)
        {
            _cellphones[_numberOfCellsphones++] = new Cellphone() {IMEI = imei, CellphoneNumber = cellphoneNumber};
        }
        else
        {
            throw new ArgumentOutOfRangeException("Only two devices are supported");
        }
        
        
    }
    
    public List<string> CellphonesInfo()
    {
        var cellphonesInfo = new List<string>();
        foreach (var cellphone in _cellphones)
        {
            if (cellphone != null)
                cellphonesInfo.Add($"IMEI:{cellphone.IMEI}, CellphoneNumber:{cellphone.CellphoneNumber}");
        }
        return cellphonesInfo;
    }
}