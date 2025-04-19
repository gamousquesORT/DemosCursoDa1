namespace InvoiceApp;

public class Invoice                         // → Rename Class
{
    private const double DEFAULT_TAX_RATE = 1.2; 
    public double Calculate(double price, double quantity)
    {
        if (price < 0 || quantity < 0) // → Extract Method
        {
            throw new ArgumentException("Price and quantity must be greater than zero.");
        }
        return price * quantity * DEFAULT_TAX_RATE;       // → Extract Field (magic number)
    }
}