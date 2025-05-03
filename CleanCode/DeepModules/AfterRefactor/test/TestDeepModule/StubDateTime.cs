using DeepModuleProd.Interfaces;
namespace TestDeepModule;

public class StubDateTime : IDate
{
    private DateTime _dateTime;
    public StubDateTime(int year, int month, int day)
    {
        _dateTime = new DateTime(year, month, day);
    }
    public DateTime Now() => DateTime.Now;
}