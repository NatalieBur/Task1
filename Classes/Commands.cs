namespace Task1.Classes;

public class Commands
{
    public void Help()
    {
        Console.WriteLine("/help - Вывод всех команд");
        Console.WriteLine("/exit - Завершть программу");
        Console.WriteLine("/createplayer Name - Создать нового игрока");
        Console.WriteLine("/player UserID - Вывод информации об игроке");
        Console.WriteLine("/playerinv UserID - Вывод информации об инвентаре игрока");
        Console.WriteLine("/itemlist - Вывод всех существующих предметов");
        Console.WriteLine("/additem UserID ItemID - Добавить предмет в инвентарь");
        Console.WriteLine("/removeitem UserID ItemID - Удалить предмет из инвентаря");
        Console.WriteLine("/top - Топ игроков");
    }
}
