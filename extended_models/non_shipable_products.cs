 namespace InternTask.extended_models;
public abstract class NonShippableExpirableProduct : ExpirableProduct
{
    public NonShippableExpirableProduct(string name, decimal price, int availableQuantity, DateTime expiryDate)
        : base(name, price, availableQuantity, expiryDate)
    {
    }
}
