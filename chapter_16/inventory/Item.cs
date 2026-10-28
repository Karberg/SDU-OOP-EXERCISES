public abstract class Item : IExpireable
{
    private string name;
    private double price;
    public Item(string name, double price)
    {
        this.name = name;
        this.price = price;
    }
    public abstract bool IsExpired();
    public string GetName()
    {
        return name;
    }
    public double GetPrice()
    {
        return price;
    }
}

