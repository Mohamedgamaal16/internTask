using InternTask.extended_models;
using InternTask.models;

namespace InternTask.data;

public class Cheese : ShippableExpirableProduct
{
    public Cheese(string name, decimal price, int availableQuantity, DateTime expiryDate, double weight)
        : base(name, price, availableQuantity, expiryDate, weight)
    {
    }
}

public class Biscuits : ShippableExpirableProduct
{
    public Biscuits(string name, decimal price, int availableQuantity, DateTime expiryDate, double weight)
        : base(name, price, availableQuantity, expiryDate, weight)
    {
    }
}

public class TV : ShippableNonExpirableProduct
{
    public TV(string name, decimal price, int availableQuantity, double weight)
        : base(name, price, availableQuantity, weight)
    {
    }
}

public class ScratchCard : NonShippableNonExpirableProduct
{
    public ScratchCard(string name, decimal price, int availableQuantity)
        : base(name, price, availableQuantity)
    {
    }
}