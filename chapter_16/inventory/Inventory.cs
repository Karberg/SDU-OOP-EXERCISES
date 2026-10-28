public class Inventory
{
    private Item[] items;

    public Inventory(Item[] items)
    {
        this.items = items;
    }

    public void AddItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                return;
            }
        }
        throw new Exception("There is no space in inventory");
    }

    public void RemoveItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] != null && items[i].GetName() == item.GetName())
            {
                items[i] = null;
                return;
            }
        }
        throw new Exception("The item is not in inventory");
    }

    public double GetInventoryValue()
    {
        double sum = 0;

        foreach (Item item in items)
        {
            sum += item.GetPrice();
        }
        return sum;
    }

    public void PrintInventory()
    {
        foreach (Item item in items)
        {
            Console.WriteLine(item.ToString());
        }
    }
}