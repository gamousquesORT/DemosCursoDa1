using DeepModuleProd.Interfaces;
namespace DeepModuleProd.Domain;

public class DateTimeProd : IDate
{
    private DateTime _dateTime;
    public DateTimeProd()
    {
        _dateTime = DateTime.Now;
    }
    public DateTime Now() => _dateTime;
}