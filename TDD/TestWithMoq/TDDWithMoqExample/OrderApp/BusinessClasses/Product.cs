namespace OrderApp.BusinessClasses;

public class Product
{
    public string ProductId { get; set; } = string.Empty;
    public int AvailableQuantity { get; set; }

    public bool HasStock(int quantity) => AvailableQuantity >= quantity;
}
