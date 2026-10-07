public class Item
{
    public string name = "";
    public double price = 0;

    public Item(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }
}