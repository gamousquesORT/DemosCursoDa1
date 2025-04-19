namespace InvoiceApp;

public class Invoice                         // → Rename Class
{
    private double _price;
    private double _quantity;
    private const double DEFAULT_TAX_RATE = 1.2; 
    public double Calculate(double price, double quantity)
    {
        _price = price;
        _quantity = quantity;
        if (_price < 0 || _quantity < 0) // → Extract Method
        {
            throw new ArgumentException("Price and quantity must be greater than zero.");
        }
        return _price * _quantity * DEFAULT_TAX_RATE;       // → 1. Extract Field (magic number)
    }
}