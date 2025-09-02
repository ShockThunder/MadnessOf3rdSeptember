namespace MadnessOf3rdSeptember.Upgrade;

public class Space : Upgrade
{
    public Space()
    {
        Name = "Space";
        CurrentLevel = 0;
        StartCost = 1000000000000;
        CurrentCost = StartCost;
        CountByLevel = 65000000;
        Description =
            "Космическая ракета 'В будущее с Шуфутинским': Отправьтесь в космическое путешествие с Шуфутинским, чтобы найти новые даты и события, которые можно перевернуть.";
    }

}
