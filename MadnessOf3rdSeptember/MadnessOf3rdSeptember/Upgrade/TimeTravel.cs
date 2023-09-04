namespace MadnessOf3rdSeptember.Upgrade;

public class TimeTravel : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public TimeTravel()
    {
        Name = "TimeTravel";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 10;
        CurrentCost = StartCost;
        CountByLevel = 3;
        Description =
            "Шуфутинский-ворота времени: Создайте порталы во времени с помощью магии Шуфутинского, чтобы получать бонусы к скорости переворота календаря.";
    }

    public void Buy()
    {
        CurrentLevel++;
        if (CurrentLevel > 6)
        {
            CurrentCost *= 30;
            CountByLevel *= 3;
        }
        else
        {
            CurrentCost *= 3;
            CountByLevel *= 3;
        }
        
    }
}