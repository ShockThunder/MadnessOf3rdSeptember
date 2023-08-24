using MadnessOf3rdSeptember.Upgrade;

namespace MadnessOf3rdSeptember;

public class GameState
{
    public long TotalScore { get; set; } = 0;
    public long CurrentScore { get; set; } = 0;
    public List<IUpgrade> Upgrades { get; set; } = new()
    {
        new Guitar()
    };

    public void IncrementScore(long value)
    {
        CurrentScore += value;
        TotalScore += value;
    }
    
    public void LoadGameState(long totalScore, long currentScore, List<IUpgrade> upgrades)
    {
        TotalScore = totalScore;
        CurrentScore = currentScore;
        Upgrades = upgrades;
    }
}