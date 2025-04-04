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

    // Method to check if product is expired
    public abstract bool IsExpired();

    // Method to reduce available quantity
    public void ReduceQuantity(int quantity)
    {
        if (quantity > AvailableQuantity)
            throw new InvalidOperationException("Not enough quantity available");
        
        AvailableQuantity -= quantity;
    }
}