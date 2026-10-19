public class FoodItem : Item
{
    DateTime expiresAt;

    public FoodItem(string name, double price, DateTime expiresAt) : base(name, price)
    {
        this.name = name;
        this.price = price;
        this.expiresAt = expiresAt;
    }

    public DateTime GetExpiresAt()
    {
        return expiresAt;
    }

    public override string ToString()
    {
        return string.Concat("Name: ", GetName(), ", Price: ", GetPrice().ToString(), ", Expiration date: ", expiresAt.ToShortDateString());
    }
}