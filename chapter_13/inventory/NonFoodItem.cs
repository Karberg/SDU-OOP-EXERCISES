public class NonFoodItem : Item
{
    string[] materials;

    public string[] GetMaterials()
    {
        return materials;
    }

    public override string ToString()
    {
        return string.Concat(GetName(), " ", GetPrice(), materials);
    }
}