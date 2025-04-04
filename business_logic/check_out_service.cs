using InternTask.models;

namespace InternTask.business_logic;
public class CheckoutService
{
    private const decimal SHIPPING_RATE = 30; 
    
    public void Checkout(Customer customer, ShoppingCart cart)
    {
        if (cart.IsEmpty())
            throw new InvalidOperationException("Cannot checkout with empty cart");
        
        foreach (var item in cart.GetItems())
        {
            if (item.Product.IsExpired())
                throw new InvalidOperationException($"Product {item.Product.Name} has expired");
            
            if (item.Product.AvailableQuantity < item.Quantity)
                throw new InvalidOperationException($"Product {item.Product.Name} is out of stock");
        }
        
        decimal subtotal = cart.GetSubtotal();
        

        List<IShippable> shippableItems = new List<IShippable>();
        
        foreach (var item in cart.GetItems())
        {
            if (item.Product is IShippable shippableProduct)
            {
                for (int i = 0; i < item.Quantity; i++)
                {
                    shippableItems.Add(shippableProduct);
                }
            }
        }
        
        decimal shippingFee = shippableItems.Any() ? SHIPPING_RATE : 0;
        
        decimal totalAmount = subtotal + shippingFee;
        
        if (customer.Balance < totalAmount)
            throw new InvalidOperationException("Insufficient balance");
        
        if (shippableItems.Any())
        {
            ShippingService shippingService = new ShippingService();
            shippingService.ShipItems(shippableItems);
        }
        
        customer.DeductBalance(totalAmount);
        
        foreach (var item in cart.GetItems())
        {
            item.Product.ReduceQuantity(item.Quantity);
        }
        
        Console.WriteLine("** Checkout receipt **");
        
        foreach (var item in cart.GetItems())
        {
            Console.WriteLine($"{item.Quantity}x {item.Product.Name} {item.GetTotal()}");
        }
        
        Console.WriteLine("----------------------");
        Console.WriteLine($"Subtotal {subtotal}");
        
        if (shippingFee > 0)
        {
            Console.WriteLine($"Shipping {shippingFee}");
        }
        
        Console.WriteLine($"Amount {totalAmount}");
        Console.WriteLine($"Balance {customer.Balance}");
                cart.Clear();
    }
}
