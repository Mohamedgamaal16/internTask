class ShippingService {
    public void shipItems(java.util.List<Shippable> items) {
        System.out.println("** Shipment notice **");
        
        double totalWeight = 0;
        
        java.util.Map<String, java.util.List<Shippable>> itemGroups = new java.util.HashMap<>();
        for (Shippable item : items) {
            String name = item.getName();
            if (!itemGroups.containsKey(name)) {
                itemGroups.put(name, new java.util.ArrayList<>());
            }
            itemGroups.get(name).add(item);
            totalWeight += item.getWeight();
        }
        
        for (String name : itemGroups.keySet()) {
            java.util.List<Shippable> group = itemGroups.get(name);
            Shippable firstItem = group.get(0);
            int count = group.size();
            double itemWeight = firstItem.getWeight();
            
            System.out.println(count + "x " + name + " " + (itemWeight * 1000) + "g");
        }
        
        System.out.println("Total package weight " + totalWeight + "kg");
    }
}
