namespace MadnessOf3rdSeptember.Upgrade;

public class VillageHouse : Upgrade
{
    public VillageHouse()
    {
        Name = "VillageHouse";
        CurrentLevel = 0;
        StartCost = 330000000;
        CurrentCost = StartCost;
        CountByLevel = 44000;
        Description =
            "Домик в деревне: Отправляйся в деревню Шуфутинского, чтобы получить мудрые советы и бонусы к переворотам.";
    }
}