namespace MadnessOf3rdSeptember.Upgrade;

public abstract class Upgrade
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long CurrentLevel { get; set; }
    public double StartCost { get; set; }
    public double CurrentCost { get; set; }
    public double CountByLevel { get; set; }

    public void Buy()
    {
        CurrentLevel++;
        CurrentCost = Math.Round(StartCost * Math.Pow(1.15, CurrentLevel), 2);
    }
}

