namespace InvoiceApp;

public class Invoice                         
{
    private decimal _price;
    private decimal _quantity;


    public Invoice() : this(0.0m, 0.0m) // → Constructor Chaining
    {
    }
    
    public Invoice(decimal price, decimal quantity)
    {
        if (price < 0 || quantity < 0)
        {
            throw new ArgumentException("Price and quantity must be greater than zero.");
        }
        _quantity = quantity;
        _price = price;
    }
    
    public decimal Price
    {
        get => _price;
        set {         
            if (value < 0)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
            _price = value;}
    }

 
    public decimal Quantity
    {
        get => _quantity;
        set {         
            if (value < 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }
            _quantity = value; 
        }
    }
    
    public decimal Calculate()
    {
        return Price * Quantity * 1.2m;       // → 1. Extract Field (magic number)
    }

    
}