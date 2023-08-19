namespace MadnessOf3rdSeptember.Upgrade;

public class Guitar : IUpgrade
{
    public string Name { get; }
    public int CurrLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCostToUpgrade { get; set; }
    public int CurrentCost { get; set; }
    public int DealByLevel { get; set; }

    public Guitar()
    {
        Name = "Guitar";
        CurrLevel = 0;
        MaxLevel = 10;
        StartCost = 200;
        CurrentCost = 0;
        CurrentCostToUpgrade = CostToUpgradeLevel();
    }
    public int CostToUpgradeLevel()
    {
        CurrentCostToUpgrade = (CurrentCost + StartCost) * 200 / 150;

        return CurrentCostToUpgrade;
    }

    public int CostAfterUpgradeLevel()
    {
        return CostToUpgradeLevel();
    }
}