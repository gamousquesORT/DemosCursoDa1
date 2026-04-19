namespace Domain;

public class DiscountService
{
    public decimal ApplyDiscount(decimal amount)
    {
        var discountPercentage = GetDiscountPercentage(new Random()); // 0% o 1%

        if (discountPercentage == 1)
        {
            return amount * 0.9m; // 10% descuento
        }

        return amount;
    }

    private  int GetDiscountPercentage(Random random)
    {
        return random.Next(0, 2);
    }
}