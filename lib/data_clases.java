class Cheese extends ShippableExpirableProduct {
    public Cheese(String name, double price, int availableQuantity, java.util.Date expiryDate, double weight) {
        super(name, price, availableQuantity, expiryDate, weight);
    }
}

class Biscuits extends ShippableExpirableProduct {
    public Biscuits(String name, double price, int availableQuantity, java.util.Date expiryDate, double weight) {
        super(name, price, availableQuantity, expiryDate, weight);
    }
}

class TV extends ShippableNonExpirableProduct {
    public TV(String name, double price, int availableQuantity, double weight) {
        super(name, price, availableQuantity, weight);
    }
}

class ScratchCard extends NonShippableNonExpirableProduct {
    public ScratchCard(String name, double price, int availableQuantity) {
        super(name, price, availableQuantity);
    }
}


