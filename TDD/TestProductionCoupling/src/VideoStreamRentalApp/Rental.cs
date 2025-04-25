namespace VideoStreamRentalApp;

public class Rental
{
    private int _daysRented;
    private string _movie;

    public Rental(string movie, int rentDays)
    {
        Movie = movie;
        DaysRented = rentDays;       
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
}