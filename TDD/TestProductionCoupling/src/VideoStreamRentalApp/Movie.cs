namespace VideoStreamRentalApp;

public abstract class Movie
{
    private string _title;
    protected const int FreeRentalDays = 3;

    protected Movie(string title)
    {
        Title = title;
    }

    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public abstract decimal GetFee(int daysRented);
    public abstract int GetLoyaltyPoints(int daysRented);
}

public class RegularMovie : Movie
{
    private const decimal NormalRentalFee = 1.5m;
    private const int LoyaltyPoints = 1;
    public RegularMovie(string title) : base(title)
    {
    }
    public override decimal GetFee(int daysRented)
    {
        if (daysRented > FreeRentalDays)
        {
            return NormalRentalFee + (daysRented- FreeRentalDays) * NormalRentalFee;
        }

        return NormalRentalFee;
    }

    public override int GetLoyaltyPoints(int daysRented)
    {
        if (daysRented > FreeRentalDays)
        {
            return LoyaltyPoints + (daysRented - FreeRentalDays);
        }
        return LoyaltyPoints;
    }
}

public class ChildrenMovie : Movie
{
    private const decimal ChildrenNormalFee = 1;
    private const int ChildrenMovieTotalLoyaltyPoints = 1;
    public ChildrenMovie(string title) : base(title)
    {
    }

    public override decimal GetFee(int daysRented)
    {
        return daysRented * ChildrenNormalFee;

    }
    
    public override int GetLoyaltyPoints(int daysRented)
    {
        return ChildrenMovieTotalLoyaltyPoints;
    }
}
