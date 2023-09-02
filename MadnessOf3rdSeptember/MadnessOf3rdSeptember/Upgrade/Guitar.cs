namespace MadnessOf3rdSeptember.Upgrade;

public class Guitar : IUpgrade
{
    public string Name { get; }
    public string Description { get; set; }
    public int CurrentLevel { get; set; }
    public int MaxLevel { get; }
    public int StartCost { get; }
    public int CurrentCost { get; set; }
    public int CountByLevel { get; set; }

    public Guitar()
    {
        Name = "Guitar";
        CurrentLevel = 0;
        MaxLevel = 10;
        StartCost = 10;
        CurrentCost = StartCost;
        CountByLevel = 2;
        Description =
            "Увеличенная гитара Шуфутинского - увеличивает размер гитары Шуфутинского в два раза, делая каждый аккорд более мелодичным и эффективным для переворотов календаря. Ваши клики звучат громче и ярче!";
    }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost = (CurrentCost + StartCost) * 200 / 150;
    }
}