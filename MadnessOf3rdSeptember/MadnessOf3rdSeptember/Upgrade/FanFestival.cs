namespace MadnessOf3rdSeptember.Upgrade;

public class FanFestival : Upgrade
{
    public FanFestival()
    {
        Name = "FanFestival";
        CurrentLevel = 0;
        StartCost = 20000000;
        CurrentCost = StartCost;
        CountByLevel = 7800;
        Description =
            "Фестиваль 'Шуфутинского поклонники': Устраивай фестиваль, чтобы собрать толпу поклонников, которые помогут переворачивать календарь вместе с вами.";
    }
}