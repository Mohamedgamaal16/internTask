class CartItem {
    private Product product;
    private int quantity;

    public CartItem(Product product, int quantity) {
        if (quantity <= 0)
            throw new IllegalArgumentException("Quantity must be positive");
        
        if (quantity > product.getAvailableQuantity())
            throw new IllegalArgumentException("Cannot add more than available quantity. Available: " + product.getAvailableQuantity());
        
        this.product = product;
        this.quantity = quantity;
    }

    public Product getProduct() {
        return product;
    }

    public int getQuantity() {
        return quantity;
    }

    public double getTotal() {
        return product.getPrice() * quantity;
    }
}