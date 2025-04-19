namespace InvoiceApp;

public class Invoice                         // → Rename Class
{
    private double _price;
    private double _quantity;
    private const double DEFAULT_TAX_RATE = 1.2;

    public Invoice() : this(0.0, 0.0) // → Constructor Chaining
    {
    }
    
    public Invoice(double price, double quantity)
    {
        if (price < 0 || quantity < 0) // → Extract Method
        {
            throw new ArgumentException("Price and quantity must be greater than zero.");
        }
        
        _price = price;
        _quantity = quantity;
    }

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

    public double Calculate()
    {
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