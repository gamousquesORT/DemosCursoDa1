namespace InvoiceApp;

public class Invoice                         
{
    private const decimal MinValidPrice = 0;
    private const decimal MinValidQty = 0;
    private const decimal DefaultTaxRate = 1.2m;
    private const string? PriceMustBeGreaterThanZero = "Price must be greater than zero.";
    private const string? QuantityMustBeGreaterThanZero = "Quantity must be greater than zero.";
    private decimal _price;
    private decimal _quantity;


    public Invoice() : this(0.0m, 0.0m) 
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
        set => ValidateAndSetPrice(value);
    }

    private void ValidateAndSetPrice(decimal value)
    {
        if (ValidatePrice(value))
        {
            throw new ArgumentException(PriceMustBeGreaterThanZero);
        }
        _price = value;
    }

    private static bool ValidatePrice(decimal value)
    {
        return value < MinValidPrice;
    }
    
    public decimal Quantity
    {
        get => _quantity;
        set => ValidateAndSetQuantity(value);
    }
    
    private void ValidateAndSetQuantity(decimal value)
    {
        if (ValidateQuantity(value))
        {
            throw new ArgumentException(QuantityMustBeGreaterThanZero);
        }
        _quantity = value;
    }
    
    private static bool ValidateQuantity(decimal value)
    {
        return value < MinValidQty;
    }


    public decimal Calculate()
    {
        return CalculateBaseTotal() * DefaultTaxRate;  
    }

    private decimal CalculateBaseTotal()
    {
        return Price * Quantity;
    }
    

}