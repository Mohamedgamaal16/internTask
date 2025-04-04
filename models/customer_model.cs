 namespace InternTask.models;
public class Customer
{
    public string Name { get; private set; }
    public decimal Balance { get; private set; }

    public Customer(string name, decimal initialBalance)
    {
        Name = name;
        Balance = initialBalance;
    }

    public void DeductBalance(decimal amount)
    {
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient balance");
        
        Balance -= amount;
    }
}