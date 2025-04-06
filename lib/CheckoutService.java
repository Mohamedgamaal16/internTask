class CheckoutService {
    private static final double SHIPPING_RATE = 30; 
    public void checkout(Customer customer, ShoppingCart cart) {
        if (cart.isEmpty())
            throw new IllegalStateException("Cannot checkout with empty cart");
        
        for (CartItem item : cart.getItems()) {
            if (item.getProduct().isExpired())
                throw new IllegalStateException("Product " + item.getProduct().getName() + " has expired");
            
            if (item.getProduct().getAvailableQuantity() < item.getQuantity())
                throw new IllegalStateException("Product " + item.getProduct().getName() + " is out of stock");
        }
        
        double subtotal = cart.getSubtotal();
        
        java.util.List<Shippable> shippableItems = new java.util.ArrayList<>();
        
        for (CartItem item : cart.getItems()) {
            if (item.getProduct() instanceof Shippable) {
                Shippable shippableProduct = (Shippable) item.getProduct();
                for (int i = 0; i < item.getQuantity(); i++) {
                    shippableItems.add(shippableProduct);
                }
            }
        }
        
        double shippingFee = !shippableItems.isEmpty() ? SHIPPING_RATE : 0;
        
        double totalAmount = subtotal + shippingFee;
        
        if (customer.getBalance() < totalAmount)
            throw new IllegalStateException("Insufficient balance");
        
        if (!shippableItems.isEmpty()) {
            ShippingService shippingService = new ShippingService();
            shippingService.shipItems(shippableItems);
        }
        
        customer.deductBalance(totalAmount);
        
        for (CartItem item : cart.getItems()) {
            item.getProduct().reduceQuantity(item.getQuantity());
        }
        
        System.out.println("** Checkout receipt **");
        
        for (CartItem item : cart.getItems()) {
            System.out.println(item.getQuantity() + "x " + item.getProduct().getName() + " " + item.getTotal());
        }
        
        System.out.println("----------------------");
        System.out.println("Subtotal " + subtotal);
        
        if (shippingFee > 0) {
            System.out.println("Shipping " + shippingFee);
        }
        
        System.out.println("Amount " + totalAmount);
        System.out.println("Balance " + customer.getBalance());
        
        cart.clear();
    }
}