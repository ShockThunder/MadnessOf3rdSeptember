namespace MadnessOf3rdSeptember.Upgrade;

public class FanFestival : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
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
        Description =
            "Фестиваль 'Шуфутинского поклонники': Устраивай фестиваль, чтобы собрать толпу поклонников, которые помогут переворачивать календарь вместе с вами.";
    }
    public void Buy()
    {
       CurrentLevel++;
       CurrentCost = (CurrentCost + StartCost) * (200 / 150) * CurrentLevel;
    }
}