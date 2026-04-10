namespace OrderApp.Interfaces;

public interface IInventoryRepository
{
    bool HasStock(string productId, int quantity);
}
