
abstract class NonShippableNonExpirableProduct extends NonExpirableProduct {
    public NonShippableNonExpirableProduct(String name, double price, int availableQuantity) {
        super(name, price, availableQuantity);
    }
}