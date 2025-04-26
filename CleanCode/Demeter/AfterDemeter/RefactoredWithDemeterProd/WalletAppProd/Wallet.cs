namespace RefactoredWithDemeter;

public class Wallet : IEquatable<Wallet>
{
    public decimal Money { get; set; } = 0;

    public void AddMoney(decimal money)
    {
        Money += money;
    }
    public void DrawMoney(decimal money)
    {
        Money -= money;
    }

    public bool Equals(Wallet? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Money == other.Money;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Wallet) obj);
    }

    public override int GetHashCode()
    {
        return Money.GetHashCode();
    }

    public static bool operator ==(Wallet? left, Wallet? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Wallet? left, Wallet? right)
    {
        return !Equals(left, right);
    }
}