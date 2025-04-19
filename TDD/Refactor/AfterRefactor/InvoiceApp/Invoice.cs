namespace InvoiceApp;

public class Invoice                         // → Rename Class
{
    private double _price;
    private double _quantity;
    private const double DEFAULT_TAX_RATE = 1.2;

    public double Price
    {
        get => _price;
        set => _price = value;
    }

    public double Quantity
    {
        get => _quantity;
        set => _quantity = value;
    }

    public double Calculate(double price, double quantity)
    {
        Price = price;
        Quantity = quantity;
        if (Price < 0 || Quantity < 0) // → Extract Method
        {
            throw new ArgumentException("Price and quantity must be greater than zero.");
        }
        return CalculatBaseTotal() * DEFAULT_TAX_RATE;       // → 1. Extract Field (magic number)
    }

    private double CalculatBaseTotal()
    {
        return Price * Quantity;
    }
}