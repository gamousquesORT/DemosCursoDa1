namespace PersonDevices;

public class Cellphone
{
    private string _imei = String.Empty;
    private Person? _owner;
    public string CellphoneNumber { get; set; } = string.Empty;

    public Cellphone()
    {
        CellphoneNumber = "numero invalido";
        IMEI = "IMEI invalido";
        _owner = null;   
    }
 
    public Cellphone(string imei, string cellphoneNumber, Person owner )
    {
        CellphoneNumber = cellphoneNumber;
        IMEI = imei;
        _owner = owner;   
    }
    public Person? Owner
    {
        get => _owner;
        set => _owner = value;
    }
    
    public string IMEI
    {
        get => _imei;
        set
        {
            if (!IsValidIMEI(value))
                throw new ArgumentException("Invalid imei");
            _imei = value;
        }
    }

    private bool IsValidIMEI(string? value)
    {
        return value != null && value.Length == 15;
    }
}