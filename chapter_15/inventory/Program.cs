FoodItem[] foodItems = new FoodItem[10];
NonFoodItem[] nonFoodItems = new NonFoodItem[10];

for (int i = 0; i < foodItems.Length; i++)
{
    foodItems[i] = new FoodItem(i.ToString(), 20 + i, DateTime.Today.AddDays(i));
}
for (int i = 0; i < nonFoodItems.Length; i++)
{
    nonFoodItems[i] = new NonFoodItem("Banana", 20 + i, ["peel", "inside"]);
}

for (int i = 0; i < foodItems.Length; i++)
{
    Console.WriteLine(foodItems[i].ToString());
}
for (int i = 0; i < nonFoodItems.Length; i++)
{
    Console.WriteLine(nonFoodItems[i].ToString());
}

