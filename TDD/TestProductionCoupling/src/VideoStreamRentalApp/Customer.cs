namespace VideoStreamRentalApp;

public class Customer
{
    private const decimal NormalRentalFee = 1.5m;
    private const int FreeRentalDays = 3;
    private const int LoyaltyPoints = 1;
    private VideoTypeRegistry _movieInfo = new VideoTypeRegistry();
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
            if (_movieInfo.IsRegular(rental.Movie))
            {
                if (rental.DaysRented > FreeRentalDays)
                {
                    rentalFee += CalculateRentalFee(rental);
                }
                else
                {
                    rentalFee += NormalRentalFee;
                }
            }
            else 
                rentalFee += 1* rental.DaysRented;  
        }
       
        return rentalFee;
    }

    private decimal CalculateRentalFee(Rental rental)
    {
        return NormalRentalFee + (rental.DaysRented - FreeRentalDays) * NormalRentalFee;
    }

    public int GetLoyaltyPoints()
    {
        int totalLoyaltyPoints = 0;

        foreach (var rental in _rentals)
        {
            if (_movieInfo.IsRegular(rental.Movie))
            {
                if (rental.DaysRented > FreeRentalDays)
                {
                    totalLoyaltyPoints += CalculateLoyaltyPoints(rental);
                }
                else
                {
                    totalLoyaltyPoints += LoyaltyPoints;
                }
            } 
            else
                totalLoyaltyPoints += 1;
        }
        return totalLoyaltyPoints;       
    }

    private int CalculateLoyaltyPoints(Rental rental)
    {
        return LoyaltyPoints + (rental.DaysRented - FreeRentalDays);
    }
}