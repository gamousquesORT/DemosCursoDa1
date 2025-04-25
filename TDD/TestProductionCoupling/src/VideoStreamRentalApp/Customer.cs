namespace VideoStreamRentalApp;

public class Customer
{
    private const decimal NormalRentalFee = 1.5m;
    private const int FreeRentalDays = 3;
    private const int LoyaltyPoints = 1;
    private int _daysRented;
    private string _movie;
    private VideoTypeRegistry _movieInfo = new VideoTypeRegistry();
    public Customer()
    {
  
    }
    public void AddRental(string movie, int daysRented)
    {   
        _movie = movie;
        _daysRented = daysRented;
    }

    public decimal GetRentalFee()
    {
        if (_movieInfo.IsRegular(_movie))
        {
            if (_daysRented > FreeRentalDays)
            {
                return CalculateRentalFee();
            }
            return NormalRentalFee;       
        }

        return 1*_daysRented;        
    }

    private decimal CalculateRentalFee()
    {
        return NormalRentalFee + (_daysRented - FreeRentalDays) * NormalRentalFee;
    }

    public int GetLoyaltyPoints()
    {
        if (_movieInfo.IsRegular(_movie))
        {
            if (_daysRented > FreeRentalDays)
            {
                return CalculateLoyaltyPoints();
            }
            return LoyaltyPoints;
        }

        return 1;
    }

    private int CalculateLoyaltyPoints()
    {
        return LoyaltyPoints + (_daysRented - FreeRentalDays);
    }
}