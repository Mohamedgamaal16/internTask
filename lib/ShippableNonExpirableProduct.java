

abstract class ShippableNonExpirableProduct extends NonExpirableProduct implements Shippable {
    protected double weight;

    public ShippableNonExpirableProduct(String name, double price, int availableQuantity, double weight) {
        super(name, price, availableQuantity);
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