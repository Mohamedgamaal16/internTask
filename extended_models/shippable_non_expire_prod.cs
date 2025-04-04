using InternTask.business_logic;

namespace InternTask.extended_models;
public abstract class ShippableNonExpirableProduct : NonExpirableProduct, IShippable
{
    public double Weight { get; protected set; }

    public ShippableNonExpirableProduct(string name, decimal price, int availableQuantity, double weight)
        : base(name, price, availableQuantity)
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