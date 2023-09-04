namespace MadnessOf3rdSeptember.Upgrade;

public class Graffity : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public Graffity()
    {
        Name = "Graffity";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 50;
        CurrentCost = StartCost;
        CountByLevel = 25;
        Description =
            "Стрит-арт граффити: Рисуйте граффити с портретами Шуфутинского на стенах, чтобы привлечь больше фанатов и повысить эффективность кликов.";
    }

    public void Buy()
    {
        CurrentLevel++;
        CountByLevel += 5 + CurrentCost / 100;
        CurrentCost = ((int)Math.Pow(StartCost, 3) / 30) * (CurrentLevel + 1);
    }
}