 namespace InternTask.business_logic;
public class ShippingService
{
    public void ShipItems(List<IShippable> items)
    {
        Console.WriteLine("** Shipment notice **");
        
        double totalWeight = 0;
        
        foreach (var group in items.GroupBy(i => i.GetName()))
        {
            var item = group.First();
            int count = group.Count();
            double itemWeight = item.GetWeight();
            totalWeight += count * itemWeight;
            
            Console.WriteLine($"{count}x {item.GetName()} {itemWeight * 1000}g");
        }
        
        Console.WriteLine($"Total package weight {totalWeight}kg");
    }
}