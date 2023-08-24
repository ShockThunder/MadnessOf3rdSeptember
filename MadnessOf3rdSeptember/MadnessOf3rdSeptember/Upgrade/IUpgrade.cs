namespace MadnessOf3rdSeptember.Upgrade;

public interface IUpgrade
{
    public string Name { get; }
    public string Image { get; set; }
    public int CurrLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }
    public long Buy(long currentCount);
}

