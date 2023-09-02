namespace MadnessOf3rdSeptember.Upgrade;

public class Restaurant : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public Restaurant()
    {
        Name = "Restaurant";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 50;
        CurrentCost = StartCost;
        CountByLevel = 2;
        Description = "Ресторан 'Мелодия вкуса': Готовьте блюда по рецептам Шуфутинского, чтобы накапливать энергию для более быстрых кликов.";
    }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost *= 3;
        CountByLevel *= CurrentLevel / 3 + 1;
    }
}