namespace MadnessOf3rdSeptember.Upgrade;

public class ShufuTower : Upgrade
{
    public ShufuTower()
    {
        Name = "ShufuTower";
        CurrentLevel = 0;
        StartCost = 1400000;
        CurrentCost = StartCost;
        CountByLevel = 1400;
        Description =
            "Шуфутинский-башня: Увеличивает скорость кликов благодаря вдохновению от Шуфутинского, который всегда знает, как перевернуть день.";
    }
}