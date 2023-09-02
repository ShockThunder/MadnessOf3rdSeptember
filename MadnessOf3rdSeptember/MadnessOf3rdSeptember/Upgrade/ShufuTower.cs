namespace MadnessOf3rdSeptember.Upgrade;

public class ShufuTower : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public ShufuTower()
    {
        Name = "ShufuTower";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 100;
        CurrentCost = StartCost;
        CountByLevel = 100;
        Description =
            "Шуфутинский-башня: Увеличивает скорость кликов благодаря вдохновению от Шуфутинского, который всегда знает, как перевернуть день.";
    }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost *= 10;
        CountByLevel *= (CurrentLevel + 1) / 2;
    }
}