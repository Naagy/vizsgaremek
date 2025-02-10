using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Real.Desktop.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using Real.Shared.Models;
using Real.HttpService;
using System.Threading.Tasks;

namespace Real.Desktop.ViewModels.RealCitizens
{
    public partial class PlayerViewModel : BaseViewModel
    {
        private readonly IPlayerHttpService _httpService;

        [ObservableProperty]
        private Player _selectedPlayer = new Player();

        [ObservableProperty]
        private List<string> _playerPositions = new List<string> { "kapus", "védő", "középpályás", "támadó" };

        [ObservableProperty]
        private ObservableCollection<Player> _players = new ObservableCollection<Player>();

        public PlayerViewModel()
        {
            _selectedPlayer = new Player();
            SelectedPlayer.BirthsDay = DateTime.Now.AddYears(-14);
            _httpService = new PlayerHttpService();
        }

        public PlayerViewModel(IPlayerHttpService? httpService)
        {
            _httpService = httpService ?? throw new ArgumentNullException(nameof(httpService));
            _selectedPlayer = new Player();
            SelectedPlayer.BirthsDay = DateTime.Now.AddYears(-14);
        }

        public async override Task InitializeAsync()
        {
            await UpdateViewAsync();
            await base.InitializeAsync();            
        }

        [RelayCommand]
        public void DoSave(Player playerDto)
        {
            Players.Add(playerDto);
            SelectedPlayer = new Player();
            SelectedPlayer.BirthsDay = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(SelectedPlayer));
        }   

        [RelayCommand]
        public void DoNewPlayer()
        {
            SelectedPlayer = new Player();
            SelectedPlayer.BirthsDay = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(SelectedPlayer));
        }

        [RelayCommand]
        public void DoDelete(Player playerDto)
        {
            Players.Remove(playerDto);
            SelectedPlayer = new Player();
            SelectedPlayer.BirthsDay = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(SelectedPlayer));
        }

        private async Task UpdateViewAsync()
        {
            List<Player> players = await _httpService.GetAllAsync();
            Players = new ObservableCollection<Player>(players);
        }
    }
}
