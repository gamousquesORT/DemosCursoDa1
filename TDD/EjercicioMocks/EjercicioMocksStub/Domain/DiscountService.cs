namespace Domain;

public class DiscountService
{
    public decimal ApplyDiscount(decimal amount, IDiscount discount)
    {
        var discountPercentage = discount.GetDiscountPercentage(); // 0% o 1%

        if (discountPercentage == 1)
        {
            return amount * 0.9m; // 10% descuento
        }

        return amount;
    }


}