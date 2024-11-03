namespace Task1.Classes;

public class Item : IObject
{
    public string Name { get; set; }
    public string Rarity { get; set; }
    public double Cost { get; set; }
    public int ItemID { get; set; }
    public Item(string name, string rarity, double cost, int itemID)
    {
        Name = name;  
        Rarity = rarity;
        Cost = cost;
        ItemID = itemID;
    }
    public object Clone()
    {
        return new Item(Name, Rarity, Cost, ItemID);
    }
}
