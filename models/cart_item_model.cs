 namespace InternTask.models;
public class CartItem
{
    public Product Product { get; private set; }
    public int Quantity { get; private set; }

    public CartItem(Product product, int quantity)
    {
        if (quantity <= 0)
            throw new ArgumentException("Quantity must be positive");
        
        if (quantity > product.AvailableQuantity)
            throw new ArgumentException($"Cannot add more than available quantity. Available: {product.AvailableQuantity}");
        
        Product = product;
        Quantity = quantity;
    }

    public decimal GetTotal()
    {
        return Product.Price * Quantity;
    }
}