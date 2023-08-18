namespace MadnessOf3rdSeptember.Upgrade;

public interface IUpgrade
{
    public string Name { get; }
    public int CurrLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCostToUpgrade { get; set; }
    public int CurrentCost { get; set; }
    public int DealByLevel { get; set; }
}