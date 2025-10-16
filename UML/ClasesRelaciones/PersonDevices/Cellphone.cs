namespace PersonDevices;

public class Cellphone
{
    private string _imei = String.Empty;
    public string CellphoneNumber { get; set; } = string.Empty;
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