namespace MadnessOf3rdSeptember.Upgrade;

public class TimeTravel : Upgrade
{
    public TimeTravel()
    {
        Name = "TimeTravel";
        CurrentLevel = 0;
        StartCost = 1100;
        CurrentCost = StartCost;
        CountByLevel = 47;
        Description =
            "Шуфутинский-ворота времени: Создайте порталы во времени с помощью магии Шуфутинского, чтобы получать бонусы к скорости переворота календаря.";
    }

}
