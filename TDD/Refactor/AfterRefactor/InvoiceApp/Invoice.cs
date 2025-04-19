namespace InvoiceApp;

public class Invoice                         // → Rename Class
{
    public double Calculate(double price, double quantity)
    {
        if (price < 0 || quantity < 0) // → Extract Method
        {
            throw new ArgumentException("Price and quantity must be greater than zero.");
        }
        return price * quantity * 1.2;       // → Extract Field (magic number)
    }
}