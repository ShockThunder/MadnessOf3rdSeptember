namespace MadnessOf3rdSeptember.Upgrade;

public class RecordStudio : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public RecordStudio()
    {
        Name = "RecordStudio";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 10;
        CurrentCost = StartCost;
        CountByLevel = 2;
        Description =
            "Шуфутинская студия записи: Записывай новые песни Шуфутинского, чтобы получать монеты и ускорять процесс переворота календаря.";
    }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost = (CurrentCost + StartCost) * 200 / 150;
    }
}