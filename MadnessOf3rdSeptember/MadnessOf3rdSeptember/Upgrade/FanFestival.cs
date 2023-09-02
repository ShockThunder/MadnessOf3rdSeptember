namespace MadnessOf3rdSeptember.Upgrade;

public class FanFestival : IUpgrade
{
    public string Name { get; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public FanFestival()
    {
        Name = "FanFestival";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 500;
        CurrentCost = StartCost;
        CountByLevel = 200;
    }
    public void Buy()
    {
       CurrentLevel++;
       CurrentCost = (CurrentCost + StartCost) * (200 / 150) * CurrentLevel;
    }
}