
abstract class NonExpirableProduct extends Product {
    public NonExpirableProduct(String name, double price, int availableQuantity) {
        super(name, price, availableQuantity);
    }

    @Override
    public boolean isExpired() {
        return false; }
}