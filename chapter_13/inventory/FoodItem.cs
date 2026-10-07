public class FoodItem : Item
{
    DateTime expiresAt;

    public DateTime GetExpiresAt()
    {
        return expiresAt;
    }

    public override string ToString()
    {
        return string.Concat(GetName(), GetPrice(), expiresAt.ToString());
    }
}