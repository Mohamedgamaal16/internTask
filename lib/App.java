import java.util.Calendar;

public class App {
     public static void main(String[] args) {
        // Create products
        Calendar calendar = Calendar.getInstance();
        calendar.add(Calendar.DAY_OF_MONTH, 30);
        Cheese cheese = new Cheese("Cheese", 100, 10, calendar.getTime(), 0.2);
        
        calendar.add(Calendar.DAY_OF_MONTH, 60); // 90 days from now
        Biscuits biscuits = new Biscuits("Biscuits", 150, 20, calendar.getTime(), 0.7);
        
        TV tv = new TV("TV", 5000, 5, 15.0);
        ScratchCard scratchCard = new ScratchCard("Scratch Card", 50, 100);
        
        // Create customerr
        Customer customer = new Customer("John", 10000);
        
        // Create cart and add items
        ShoppingCart cart = new ShoppingCart();
        cart.add(cheese, 2);
        cart.add(biscuits, 1);
        cart.add(tv, 1);
        cart.add(scratchCard, 1);
        
        // Checkout
        CheckoutService checkoutService = new CheckoutService();
        checkoutService.checkout(customer, cart);
    }
}
