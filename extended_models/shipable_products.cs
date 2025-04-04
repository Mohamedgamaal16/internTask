using InternTask.business_logic;

namespace InternTask.extended_models;

public abstract class ShippableExpirableProduct : ExpirableProduct, IShippable
{
    public double Weight { get; protected set; }

    public ShippableExpirableProduct(string name, decimal price, int availableQuantity, DateTime expiryDate, double weight)
        : base(name, price, availableQuantity, expiryDate)
    {
        Weight = weight;
    }

    public string GetName()
    {
        return Name;
    }

    public double GetWeight()
    {
        return Weight;
    }
}