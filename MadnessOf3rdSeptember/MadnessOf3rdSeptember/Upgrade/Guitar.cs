namespace MadnessOf3rdSeptember.Upgrade;

public class Guitar : Upgrade
{
    public Guitar()
    {
        Name = "Guitar";
        CurrentLevel = 0;
        StartCost = 15;
        CurrentCost = StartCost;
        CountByLevel = 0.1;
        Description =
            "Увеличенная гитара Шуфутинского - увеличивает размер гитары Шуфутинского в два раза, делая каждый аккорд более мелодичным и эффективным для переворотов календаря. Ваши клики звучат громче и ярче!";
    }
}