namespace VideoStreamRentalApp;



public class Rental
{
    private int _daysRented;
    private readonly Movie _movie;

    public Rental(string title, int rentDays)
    { 
        _movie = VideoTypeRegistry.GetMovie(title);
        
        DaysRented = rentDays;       
    }
    
    public decimal GetFee()
    {
        return _movie.GetFee(DaysRented);
    }

    public int GetLoyaltyPoints()
    {
        return _movie.GetLoyaltyPoints(DaysRented);       
    }
    
    public int DaysRented
    {
        get => _daysRented;
        set => _daysRented = value;
    }
    
}