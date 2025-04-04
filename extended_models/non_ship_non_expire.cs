namespace InternTask.extended_models;

public abstract class NonShippableNonExpirableProduct : NonExpirableProduct
{
    public NonShippableNonExpirableProduct(string name, decimal price, int availableQuantity)
        : base(name, price, availableQuantity)
    {
    }
}