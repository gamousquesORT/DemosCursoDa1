namespace VideoStreamRentalApp;

public class Customer
{
    private List<Rental> _rentals = new List<Rental>();
    
    public Customer()
    {

    }
    public void AddRental(string movie, int daysRented)
    {
        _rentals.Add(new Rental(movie, daysRented));
    }

    public decimal GetRentalFee()
    {
        decimal rentalFee = 0;

        foreach (var rental in _rentals)
        {
            rentalFee += rental.GetFee();

        }

        return rentalFee;
    }

        
    public int GetLoyaltyPoints()
    {
        int totalLoyaltyPoints = 0;

        foreach (var rental in _rentals)
        {
            totalLoyaltyPoints += rental.GetLoyaltyPoints();
        }
        return totalLoyaltyPoints;       
    }


}