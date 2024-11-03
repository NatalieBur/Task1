namespace Task1.Classes;

public class Player
{
    public string Name { get; set; }
    public int UserID { get; set; }
    public string Inventory { get; set; }
    public int Pos { get; set; }
    public Player(string name, int userId, string inventory, int pos)
    {
        Name = name;
        UserID = userId;
        Inventory = inventory;
        Pos = pos;
    }
    public override string ToString()
    {
        return $"Name: {Name}, UserID: {UserID}, Position: {Pos}, Items: {Inventory}";
    }
}
