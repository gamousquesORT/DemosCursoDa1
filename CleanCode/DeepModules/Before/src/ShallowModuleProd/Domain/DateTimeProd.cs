using ShallowModuleProd.Interfaces;
namespace ShallowModuleProd.Domain;

public class DateTimeProd : IDate
{
    private DateTime _dateTime;
    public DateTimeProd()
    {
        _dateTime = DateTime.Now;
    }
    public DateTime Now() => _dateTime;
}