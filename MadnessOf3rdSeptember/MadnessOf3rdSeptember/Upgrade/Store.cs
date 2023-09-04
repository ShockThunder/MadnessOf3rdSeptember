namespace MadnessOf3rdSeptember.Upgrade;

public class Store : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public Store()
    {
        Name = "Store";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 5000;
        CurrentCost = StartCost;
        CountByLevel = 2;
        Description =
            "Магазин 'Время в руках': Позволяет игроку покупать артефакты и волшебные предметы для мгновенного переворота даты.";
    }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost = StartCost * (int)(Math.Round(5.0 * CurrentLevel));
        CountByLevel = (int)(CurrentCost * 0.01);
    }
}