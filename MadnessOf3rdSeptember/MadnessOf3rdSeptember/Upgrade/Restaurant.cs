namespace MadnessOf3rdSeptember.Upgrade;

public class Restaurant : Upgrade
{
    public Restaurant()
    {
        Name = "Restaurant";
        CurrentLevel = 0;
        StartCost = 130000;
        CurrentCost = StartCost;
        CountByLevel = 1400;
        Description = "Ресторан 'Мелодия вкуса': Готовьте блюда по рецептам Шуфутинского, чтобы накапливать энергию для более быстрых кликов.";
    }
}