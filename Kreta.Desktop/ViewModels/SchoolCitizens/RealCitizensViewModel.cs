using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Real.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace Real.Desktop.ViewModels.RealCitizens
{
    public partial class RealCitizensViewModel : BaseViewModel
    {
        private PlayerViewModel _playerViewModel;

        public RealCitizensViewModel()
        {
            _currentRealCitizensChildView = new PlayerViewModel();
            _playerViewModel = new PlayerViewModel();
        }

        public RealCitizensViewModel(PlayerViewModel playerViewModel)
        {
            _playerViewModel = playerViewModel;

            _currentRealCitizensChildView= new PlayerViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentRealCitizensChildView;

        [RelayCommand]
        public async Task ShowPlayerView()
        {
            await _playerViewModel.InitializeAsync();
            CurrentRealCitizensChildView = _playerViewModel;
        }
    }
}
