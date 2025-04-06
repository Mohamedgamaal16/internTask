
abstract class NonShippableExpirableProduct extends ExpirableProduct {
    public NonShippableExpirableProduct(String name, double price, int availableQuantity, java.util.Date expiryDate) {
        super(name, price, availableQuantity, expiryDate);
    }
}