namespace MadnessOf3rdSeptember.Upgrade;

public class Space : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public Space()
    {
        Name = "Space";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 10;
        CurrentCost = StartCost;
        CountByLevel = 2;
        Description =
            "Космическая ракета 'В будущее с Шуфутинским': Отправьтесь в космическое путешествие с Шуфутинским, чтобы найти новые даты и события, которые можно перевернуть.";
    }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost = (CurrentCost + StartCost) * 200 / 150;
    }
}