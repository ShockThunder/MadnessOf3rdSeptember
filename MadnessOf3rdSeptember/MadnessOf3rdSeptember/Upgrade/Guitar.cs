namespace MadnessOf3rdSeptember.Upgrade;

public class Guitar : IUpgrade
{
    public string Name { get; }
    public string Image { get; set; }
    public int CurrLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public Guitar()
    {
        Name = "Guitar";
        CurrLevel = 0;
        MaxLevel = 10;
        StartCost = 10;
        CurrentCost = StartCost;
        CountByLevel = 2;
    }

    public int Buy(int currentCount)
    {
        if(currentCount < CurrentCost)
            return currentCount;

        CurrLevel++;
        currentCount -= CurrentCost;
        CurrentCost = (CurrentCost + StartCost) * 200 / 150;

        return currentCount;
    }
}