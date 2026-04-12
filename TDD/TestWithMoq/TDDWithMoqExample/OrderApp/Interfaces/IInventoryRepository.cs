using OrderApp.BusinessClasses;

namespace OrderApp.Interfaces;

public interface IInventoryRepository
{
    Inventory GetByProductId(string productId);
}
