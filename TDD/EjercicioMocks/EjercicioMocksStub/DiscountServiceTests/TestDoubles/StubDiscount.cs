using Domain;

namespace DomainTests.TestDoubles;

public class StubDiscount : IDiscount
{
    private readonly int _valueToReturn;

    public StubDiscount(int valueToReturn)
    {
        _valueToReturn = valueToReturn;
    }

    public int GetDiscountPercentage()
    {
        return _valueToReturn;
    }
}




