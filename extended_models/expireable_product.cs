using InternTask.models;

namespace InternTask.extended_models;
public abstract class ExpirableProduct : Product
{
    public DateTime ExpiryDate { get; protected set; }

    public ExpirableProduct(string name, decimal price, int availableQuantity, DateTime expiryDate)
        : base(name, price, availableQuantity)
    {
        ExpiryDate = expiryDate;
    }

    public override bool IsExpired()
    {
        return DateTime.Now > ExpiryDate;
    }
}