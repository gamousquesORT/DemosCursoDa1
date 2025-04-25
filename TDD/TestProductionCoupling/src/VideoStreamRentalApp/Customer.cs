namespace VideoStreamRentalApp;

public class Customer
{
    private const decimal NormalRentalFee = 1.5m;
    private const int FreeRentalDays = 3;
    private const int LoyaltyPoints = 1;
    private int _daysRented;
    private string _movie;

    enum MovieType
    {
        Regular,
        Children,
    }; 
    
    private Dictionary<string, MovieType> _movieInfo = new Dictionary<string, MovieType>();

    public Customer()
    {
        _movieInfo.Add("Regular Movie", MovieType.Regular);
        _movieInfo.Add("Children Movie", MovieType.Children);       
    }
    public void AddRental(string movie, int daysRented)
    {   
        _movie = movie;
        _daysRented = daysRented;
    }
    public decimal GetRentalFee()
    {
        if (_movieInfo[_movie] == MovieType.Regular)
        {
            if (_daysRented > FreeRentalDays)
            {
                return CalculateRentalFee();
            }
            return NormalRentalFee;       
        }

        return 1;        
    }

    private decimal CalculateRentalFee()
    {
        return NormalRentalFee + (_daysRented - FreeRentalDays) * NormalRentalFee;
    }

    public int GetLoyaltyPoints()
    {
        if (_daysRented > FreeRentalDays)
        {
            return CalculateLoyaltyPoints();
        }
        return LoyaltyPoints;
    }

    private int CalculateLoyaltyPoints()
    {
        return LoyaltyPoints + (_daysRented - FreeRentalDays);
    }
}