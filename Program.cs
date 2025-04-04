using InternTask.business_logic;
using InternTask.data;
using InternTask.models;

public class Program
{
    public static void Main()
    {

        var cheese = new Cheese("Cheese", 100m, 10, DateTime.Now.AddDays(30), 0.2);
        var biscuits = new Biscuits("Biscuits", 150m, 20, DateTime.Now.AddDays(90), 0.7);
        var tv = new TV("TV", 5000m, 5, 15.0);
        var scratchCard = new ScratchCard("Scratch Card", 50m, 100);
        
        var customer = new Customer("John", 10000m);
        

        var cart = new ShoppingCart();
        cart.Add(cheese, 2);
        cart.Add(biscuits, 1);
        cart.Add(tv, 1);
        cart.Add(scratchCard, 1);
        

        var checkoutService = new CheckoutService();
        checkoutService.Checkout(customer, cart);
    }
}