abstract class ShippableExpirableProduct extends ExpirableProduct implements Shippable {
    protected double weight;

    public ShippableExpirableProduct(String name, double price, int availableQuantity, java.util.Date expiryDate, double weight) {
        super(name, price, availableQuantity, expiryDate);
        this.weight = weight;
    }

    @Override
    public String getName() {
        return name;
    }

    @Override
    public double getWeight() {
        return weight;
    }
}
