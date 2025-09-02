namespace MadnessOf3rdSeptember.Upgrade;

public class Store : Upgrade
{
    public Store()
    {
        Name = "Store";
        CurrentLevel = 0;
        StartCost = 5100000000;
        CurrentCost = StartCost;
        CountByLevel = 1600000;
        Description =
            "Магазин 'Время в руках': Позволяет игроку покупать артефакты и волшебные предметы для мгновенного переворота даты.";
    }

}
