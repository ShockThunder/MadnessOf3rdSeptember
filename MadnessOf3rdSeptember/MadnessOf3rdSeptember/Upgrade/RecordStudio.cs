namespace MadnessOf3rdSeptember.Upgrade;

public class RecordStudio : Upgrade
{
    public RecordStudio()
    {
        Name = "RecordStudio";
        CurrentLevel = 0;
        StartCost = 75000000000;
        CurrentCost = StartCost;
        CountByLevel = 1600000;
        Description =
            "Шуфутинская студия записи: Записывай новые песни Шуфутинского, чтобы получать монеты и ускорять процесс переворота календаря.";
    }
}