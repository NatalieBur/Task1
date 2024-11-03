namespace Task1.Classes;

public class Inventory : IObject
{
    public List<Item> Items { get; set; } = new List<Item>
    {
        new Item("Шлем", "Редкий", 50, 1),
        new Item("Нагрудник", "Редкий", 75, 2),
        new Item("Штаны", "Редкий", 85, 3),
        new Item("Ботнки", "Редкий", 80, 4),
        new Item("Меч", "Обычный", 10, 5),
        new Item("Топор", "Обычный", 20, 6),
        new Item("Кирка", "Обычный", 30, 7),
        new Item("Лук", "Эпический", 100, 8),
        new Item("Зелье", "Легендарный", 150, 9),
        new Item("Щит", "Редкий", 60, 10)
    };

    public object Clone()
    {
        return new List<Item>();
    }
}