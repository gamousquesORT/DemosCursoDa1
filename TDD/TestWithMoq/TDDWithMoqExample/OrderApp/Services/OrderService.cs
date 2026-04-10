using OrderApp.Interfaces;
using OrderApp.Models;

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
        if (!_inventory.HasStock(order.ProductId, order.Quantity))
            return OrderResult.InsufficientStock;

        _emailService.SendConfirmation(order.CustomerEmail, order.Id);
        return OrderResult.Success;
    }
}
