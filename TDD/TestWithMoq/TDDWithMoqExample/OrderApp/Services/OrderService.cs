using OrderApp.BusinessClasses;
using OrderApp.Interfaces;

namespace OrderApp.Services;

public class OrderService
{
    private readonly IInventoryRepository _inventory;
    private readonly IEmailService _emailService;

    public OrderService(IInventoryRepository inventory, IEmailService emailService)
    {
        _inventory = inventory;
        _emailService = emailService;
    }

    public OrderResult PlaceOrder(Order order)
    {
        var inventory = _inventory.GetByProductId(order.ProductId);

        if (!inventory.HasStock(order.Quantity))
            return OrderResult.InsufficientStock;

        _emailService.SendConfirmation(order.CustomerEmail, order.Id);
        return OrderResult.Success;
    }
}
