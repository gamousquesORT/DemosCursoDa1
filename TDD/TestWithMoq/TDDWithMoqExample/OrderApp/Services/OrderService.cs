using OrderApp.BusinessClasses;
using OrderApp.Interfaces;

namespace OrderApp.Services;

public class OrderService
{
    private readonly IProductRepository _product;
    private readonly IEmailSender _emailSender;

    public OrderService(IProductRepository product, IEmailSender emailSender)
    {
        _product = product;
        _emailSender = emailSender;
    }

    public int PlaceOrder(Order order)
    {
        var product = _product.GetByProductId(order.ProductId);

        if (!product.HasStock(order.Quantity))
            throw new ArgumentException("Not enough stock");
        product.AvailableQuantity -= order.Quantity;
        _emailSender.SendConfirmation(order.CustomerEmail, order.Id);
        return product.AvailableQuantity;
    }
}
