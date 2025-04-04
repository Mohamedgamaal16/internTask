 namespace InternTask.models;
public abstract class NonExpirableProduct : Product
{
    public NonExpirableProduct(string name, decimal price, int availableQuantity)
        : base(name, price, availableQuantity)
    {
    }

    public override bool IsExpired()
    {
        return false; // Non-expirable products never expire
    }
}