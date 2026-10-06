List<string> fruitList = new List<string> { "Mango", "Apple", "Banana" };

fruitList.Add("Orange");
fruitList.Remove("Apple");

foreach (string fruit in fruitList)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitById = new Dictionary<int, string>
{
    { 1, "Mango" },
    { 2, "Apple" },
    { 3, "Banana" }
};

fruitById.Add(4, "Orange");

foreach (KeyValuePair<int, string> pair in fruitById)
{
    Console.WriteLine($"ID {pair.Key}: {pair.Value}");
}