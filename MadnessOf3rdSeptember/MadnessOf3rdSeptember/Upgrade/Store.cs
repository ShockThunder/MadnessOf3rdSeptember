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