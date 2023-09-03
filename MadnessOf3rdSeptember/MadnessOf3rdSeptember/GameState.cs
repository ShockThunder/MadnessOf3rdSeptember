
using Blazored.LocalStorage;
using MadnessOf3rdSeptember.Upgrade;

namespace MadnessOf3rdSeptember;

public class GameState
{
    private ILocalStorageService _storageService;

    public GameState(ILocalStorageService storageService)
    {
        _storageService = storageService;
    }

    public double TotalScore { get; set; } = 0;
    public double CurrentScore { get; set; } = 0;

    public List<Upgrade.Upgrade> Upgrades { get; set; } = InitiateUpgrades();

    private static List<Upgrade.Upgrade> InitiateUpgrades()
    {
        var upgrades = new List<Upgrade.Upgrade>()
        {
            new Guitar(),
            new FanFestival(),
            new ConcertHall(),
            new Graffity(),
            new RecordStudio(),
            new Restaurant(),
            new ShufuTower(),
            new Space(),
            new Store(),
            new TimeTravel(),
            new VillageHouse()
        };

        return upgrades.OrderBy(x => x.StartCost).ToList();
    }

    public void IncrementScore(double value)
    {
        CurrentScore = Math.Round(CurrentScore + value, 2);
        TotalScore = Math.Round(TotalScore + value, 2);
    }

    public void InitiateGameState()
    {
        TotalScore = 0;
        CurrentScore = 0;
        Upgrades = InitiateUpgrades();

    }
    
    public async Task LoadGameState()
    {
        TotalScore = await _storageService.GetItemAsync<double>("TotalScore");
        CurrentScore = await _storageService.GetItemAsync<double>("CurrentScore");

        var upgrades = await _storageService.GetItemAsync<List<SavedUpgrade>>("Upgrades");
        if(upgrades == null)
            return;
        foreach (var upgrade in Upgrades)
        {
            var savedUpgrade = upgrades.FirstOrDefault(x => x.Name == upgrade.Name);
            if (savedUpgrade != null)
            {
                upgrade.CurrentCost = savedUpgrade.CurrentCost;
                upgrade.CurrentLevel = savedUpgrade.CurrentLevel;
            }
        }
    }

    public async Task SaveGameState()
    {
        await _storageService.SetItemAsync("TotalScore", TotalScore);
        await _storageService.SetItemAsync("CurrentScore", CurrentScore);

        var list = new List<SavedUpgrade>();
        foreach (var upgrade in Upgrades)
        {
            list.Add(new SavedUpgrade()
            {
                Name = upgrade.Name,
                CurrentCost = upgrade.CurrentCost,
                CurrentLevel = upgrade.CurrentLevel
            });
        }

        await _storageService.SetItemAsync("Upgrades", list);
    }

    private class SavedUpgrade
    {
        public string Name { get; set; }
        public double CurrentCost { get; set; }
        public long CurrentLevel { get; set; }
    }
}