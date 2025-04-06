
public class ExpirableProduct extends Product {
    protected java.util.Date expiryDate;

    public ExpirableProduct(String name, double price, int availableQuantity, java.util.Date expiryDate) {
        super(name, price, availableQuantity);
        this.expiryDate = expiryDate;
    }

    @Override
    public boolean isExpired() {
        return new java.util.Date().after(expiryDate);
    }
}