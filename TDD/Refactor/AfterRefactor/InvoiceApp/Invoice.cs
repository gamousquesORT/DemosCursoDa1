namespace InvoiceApp;

public class Invoice                         
{
    private const decimal MIN_VALID_PRICE = 0;
    private const decimal MIN_VALID_QTY = 0;
    private const decimal DEFAULT_TAX_RATE = 1.2m;
    private decimal _price;
    private decimal _quantity;


    public Invoice() : this(0.0m, 0.0m) // → Constructor Chaining
    {
    }
    
    public Invoice(decimal price, decimal quantity)
    {
        ValidateAndSetPrice(price);
        ValidateAndSetQuantity(quantity);
    }
    
    public decimal Price
    {
        get => _price;
        set { ValidateAndSetPrice(value); }
    }

    private void ValidateAndSetPrice(decimal value)
    {
        if (ValidatePrice(value))
        {
            throw new ArgumentException("Price must be greater than zero.");
        }

        _price = value;
    }


    public decimal Quantity
    {
        get => _quantity;
        set { ValidateAndSetQuantity(value); }
    }

    private void ValidateAndSetQuantity(decimal value)
    {
        if (ValidateQuantity(value))
        {
            throw new ArgumentException("Quantity must be greater than zero.");
        }

        _quantity = value;
    }

    public decimal Calculate()
    {
        return CalculatBaseTotal() * DEFAULT_TAX_RATE;       // → 1. Extract Field (magic number)
    }

    private decimal CalculatBaseTotal()
    {
        return Price * Quantity;
    }
    
    private static bool ValidatePrice(decimal value)
    {
        return value < MIN_VALID_PRICE;
    }
    
    private static bool ValidateQuantity(decimal value)
    {
        return value < MIN_VALID_QTY;
    }
    
}