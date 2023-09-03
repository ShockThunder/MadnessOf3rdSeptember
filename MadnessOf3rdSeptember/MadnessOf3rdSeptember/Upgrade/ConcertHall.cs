namespace MadnessOf3rdSeptember.Upgrade;

public class ConcertHall : Upgrade
{
    public ConcertHall()
    {
        Name = "ConcertHall";
        CurrentLevel = 0;
        StartCost = 100;
        CurrentCost = StartCost;
        CountByLevel = 1;
        Description =
            "Концертный зал 'Календарь': Организовывай концерты Шуфутинского, чтобы собрать аплодисменты, которые ускоряют перевороты календаря.";
    }
}