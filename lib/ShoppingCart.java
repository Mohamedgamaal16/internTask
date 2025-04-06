
class ShoppingCart {
    private java.util.List<CartItem> items = new java.util.ArrayList<>();

    public void add(Product product, int quantity) {
        if (product.getAvailableQuantity() < quantity)
            throw new IllegalStateException("Not enough quantity available for " + product.getName() + ". Available: " + product.getAvailableQuantity());
        
        items.add(new CartItem(product, quantity));
    }

    public java.util.List<CartItem> getItems() {
        return items;
    }

    public boolean isEmpty() {
        return items.isEmpty();
    }

    public double getSubtotal() {
        double subtotal = 0;
        for (CartItem item : items) {
            subtotal += item.getTotal();
        }
        return subtotal;
    }

    public void clear() {
        items.clear();
    }
}