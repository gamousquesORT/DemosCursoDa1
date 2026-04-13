using OrderApp.BusinessClasses;

namespace OrderApp.Interfaces;

public interface IProductRepository
{
    Product GetByProductId(string productId);
}
