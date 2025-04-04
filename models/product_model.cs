 namespace InternTask.models;
public abstract class Product
{
    public string Name { get; protected set; }
    public decimal Price { get; protected set; }
    public int AvailableQuantity { get; protected set; }

    public Product(string name, decimal price, int availableQuantity)
    {
        Name = name;
        Price = price;
        AvailableQuantity = availableQuantity;
    }

    public abstract bool IsExpired();

    public void ReduceQuantity(int quantity)
    {
        if (quantity > AvailableQuantity)
            throw new InvalidOperationException("Not enough quantity available");
        
        AvailableQuantity -= quantity;
    }
}