namespace RefactoredWithDemeter;

public class Customer : IEquatable<Customer>
{
    private Wallet _wallet =new Wallet();
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public void AddMoney(decimal amount)
    {
        _wallet.AddMoney(amount);
    }

    public Customer()
    {
    }

    public bool Pay(decimal amountToPay)
    {
        if (_wallet.Money >= amountToPay)
        {
            _wallet.DrawMoney(amountToPay);
            return true;
        }

        throw new ArgumentException("Not enough money");
    }

    public bool Equals(Customer? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return FirstName == other.FirstName && LastName == other.LastName;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Customer) obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return (FirstName.GetHashCode() * 397) ^ LastName.GetHashCode();
        }
    }

    public static bool operator ==(Customer? left, Customer? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Customer? left, Customer? right)
    {
        return !Equals(left, right);
    }
}