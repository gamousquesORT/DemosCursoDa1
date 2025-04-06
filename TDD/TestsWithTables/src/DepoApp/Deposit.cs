namespace DepoDominio;

/*
 * esta clase NO ESTA REFACTOREADA - Nos encontramos construyendo el arnes de pruebas para poder refactorear con tranquilidad
 */
public class Deposit
{
    public float  SizePrice { set; get; }
    public int Days { set; get; }
    public bool Climatization { set; get; }
    public Promotion Promotion { set; get; }

    public float ComputePrice()
    {
        float basePrice = SizePrice * Days;
        float daydiscount = 0;
        float climatizationDiscount = (Climatization) ? 20 : 0;

        if (Days <= 0)
        {
            throw new ArgumentException("Error: Days should be greater than 1");
        }

        if (Promotion.PromotionDiscount < 0)
        {
            throw new ArgumentException("Error: Invalid promotion discount");            
        } 
            
            
        if (Days < 7 && Days > 0)
            daydiscount = 0;
        else if (Days >= 7 && Days < 14)
            daydiscount = 5;
        else
            daydiscount = 10;

        return basePrice - (basePrice * daydiscount/100) - (basePrice * Promotion.PromotionDiscount/100) + climatizationDiscount;

    }
}