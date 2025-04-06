
public abstract class Product {
    protected String name;
    protected double price;
    protected int availableQuantity;

    public Product(String name, double price, int availableQuantity) {
        this.name = name;
        this.price = price;
        this.availableQuantity = availableQuantity;
    }

    public String getName() {
        return name;
    }

    public double getPrice() {
        return price;
    }

    public int getAvailableQuantity() {
        return availableQuantity;
    }

    public abstract boolean isExpired();

    public void reduceQuantity(int quantity) {
        if (quantity > availableQuantity)
            throw new IllegalStateException("Not enough quantity available");
        
        availableQuantity -= quantity;
    }
}
