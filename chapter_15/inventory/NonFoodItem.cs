public class NonFoodItem : Item
{
    string[] materials = [];

    public NonFoodItem(string name, double price, string[] materials) : base(name, price)
    {
        this.name = name;
        this.price = price;
        this.materials = materials;
    }

    public string[] GetMaterials()
    {
        return materials;
    }

    public override string ToString()
    {

        string materialsList = string.Join(", ", materials);

        return string.Concat("Name: ", GetName(), ", Price: ", GetPrice(), ", Materials: ", materialsList);
    }
}