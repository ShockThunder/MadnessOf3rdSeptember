namespace MadnessOf3rdSeptember.Upgrade;

public class ShufuTower : IUpgrade
{
    public string Name { get; }
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
        StartCost = 10;
        CurrentCost = StartCost;
        CountByLevel = 2;
    }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost = (CurrentCost + StartCost) * 200 / 150;
    }
}