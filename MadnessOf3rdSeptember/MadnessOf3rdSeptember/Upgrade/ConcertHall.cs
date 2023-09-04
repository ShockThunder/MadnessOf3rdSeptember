namespace MadnessOf3rdSeptember.Upgrade;

public class ConcertHall : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public ConcertHall()
    {
        Name = "ConcertHall";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 10;
        CurrentCost = StartCost;
        CountByLevel = 120;
        Description =
            "Концертный зал 'Календарь': Организовывай концерты Шуфутинского, чтобы собрать аплодисменты, которые ускоряют перевороты календаря.";
    }

    public void Buy()
    {
        CurrentLevel++;
        if (CurrentLevel == 9)
        {
            CurrentCost = (CurrentCost + StartCost) * (200 / 150) * StartCost * 5;
            CountByLevel += 5000;
        }

        CountByLevel += CountByLevel * StartCost / CurrentLevel / 10;
        CurrentCost = (CurrentCost + StartCost) * (200 / 150) * StartCost;
    }
}