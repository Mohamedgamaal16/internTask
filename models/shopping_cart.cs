 namespace InternTask.models;
public class ShoppingCart
{
    private List<CartItem> items = new List<CartItem>();

    public void Add(Product product, int quantity)
    {
        if (product.AvailableQuantity < quantity)
            throw new InvalidOperationException($"Not enough quantity available for {product.Name}. Available: {product.AvailableQuantity}");
        
        items.Add(new CartItem(product, quantity));
    }

    public List<CartItem> GetItems()
    {
        return items;
    }

    public bool IsEmpty()
    {
        return !items.Any();
    }

    public decimal GetSubtotal()
    {
        return items.Sum(item => item.GetTotal());
    }

    public void Clear()
    {
        items.Clear();
    }
}