namespace VideoStreamRentalApp;

public class Rental
{
    private int _daysRented;
    private string _movie;
    private VideoTypeRegistry _movieInfo = new VideoTypeRegistry();
    private const int ChildrenNormalFee = 1;
    private const decimal NormalRentalFee = 1.5m;
    private const int FreeRentalDays = 3;
    private const int ChildrenMovieTotalLoyaltyPoints = 1;
    private const int LoyaltyPoints = 1;
       
    public Rental(string movie, int rentDays)
    {
        Movie = movie;
        DaysRented = rentDays;       
    }
    
    public decimal GetRentalFee()
    {
        if (_movieInfo.IsRegular(this.Movie))
        {
            return RegularMovieRentalFee();
        }
        else 
            return ChildrenRentalDaysFee();  
    }

    private decimal RegularMovieRentalFee()
    {

        if (this.DaysRented > FreeRentalDays)
        {
            return CalculateRentalFee();
        }

        return NormalRentalFee;
    }
    
    private decimal ChildrenRentalDaysFee()
    {
        return _daysRented * ChildrenNormalFee;

    }

    private decimal CalculateRentalFee()
    {
        return NormalRentalFee + (this.DaysRented - FreeRentalDays) * NormalRentalFee;
    }

    public string Movie
    {
        get => _movie;
        set => _movie = value;
    }

    public int DaysRented
    {
        get => _daysRented;
        set => _daysRented = value;
    }
    
    public int GetLoyaltyPoints() 
    {
            if (_movieInfo.IsRegular(this.Movie))
            {
                return RegularMovieTotalLoyaltyPoints();
            } 
            return ChildrenMovieTotalLoyaltyPoints;
    }    
    
    private int RegularMovieTotalLoyaltyPoints()
     {
         if (this.DaysRented > FreeRentalDays)
         {
             return CalculateLoyaltyPoints();
         }
         return LoyaltyPoints;
     }
     
     private int CalculateLoyaltyPoints()
     {
         return LoyaltyPoints + (this.DaysRented - FreeRentalDays);
     }
}