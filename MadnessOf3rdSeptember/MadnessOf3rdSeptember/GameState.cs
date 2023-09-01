using System.Text.Json;
using System.Text.Json.Serialization;
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

    public long TotalScore { get; set; } = 0;
    public long CurrentScore { get; set; } = 0;

    public List<IUpgrade> Upgrades { get; set; } = InitiateUpgrades();

    private static List<IUpgrade> InitiateUpgrades()
    {
        return new()
        {
            new Guitar()
        };
    }

    public void IncrementScore(long value)
    {
        CurrentScore += value;
        TotalScore += value;
    }

    public void InitiateGameState()
    {
        TotalScore = 0;
        CurrentScore = 0;
        Upgrades = InitiateUpgrades();

    }
    
    public async Task LoadGameState()
    {
        TotalScore = await _storageService.GetItemAsync<long>("TotalScore");
        CurrentScore = await _storageService.GetItemAsync<long>("CurrentScore");

        var upgrades = await _storageService.GetItemAsync<List<SavedUpgrade>>("Upgrades");
        if(upgrades == null)
            return;
        foreach (var upgrade in Upgrades)
        {
            var savedUpgrade = upgrades.First(x => x.Name == upgrade.Name);
            upgrade.CurrentCost = savedUpgrade.CurrentCost;
            upgrade.CurrentLevel = savedUpgrade.CurrentLevel;
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

    public async void ClearAll()
    {
        await _storageService.ClearAsync();
        await LoadGameState();
    }

    private class SavedUpgrade
    {
        public string Name { get; set; }
        public int CurrentCost { get; set; }
        public int CurrentLevel { get; set; }
    }
}