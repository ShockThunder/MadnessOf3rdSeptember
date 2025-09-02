namespace MadnessOf3rdSeptember.Upgrade;

public class Graffity : Upgrade
{
    public Graffity()
    {
        Name = "Graffity";
        CurrentLevel = 0;
        StartCost = 12000;
        CurrentCost = StartCost;
        CountByLevel = 260;
        Description =
            "Стрит-арт граффити: Рисуйте граффити с портретами Шуфутинского на стенах, чтобы привлечь больше фанатов и повысить эффективность кликов.";
    }

}
