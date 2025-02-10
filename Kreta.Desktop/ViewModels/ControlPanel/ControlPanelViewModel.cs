using CommunityToolkit.Mvvm.ComponentModel;
using Real.Desktop.ViewModels.Base;
using Real.HttpService;
using System;
using System.Threading.Tasks;

namespace Real.Desktop.ViewModels.ControlPanel
{
    public partial class ControlPanelViewModel: BaseViewModel
    {
        private readonly IPlayerHttpService _playerHttpService;

        [ObservableProperty]
        private int _numberOfPlayer;

        public ControlPanelViewModel()
        {
            _playerHttpService = new PlayerHttpService();
        }
        public ControlPanelViewModel(IPlayerHttpService? playerHttpService)
        {
            _playerHttpService=playerHttpService ?? throw new ArgumentException(nameof(playerHttpService));
        }

        public async override Task InitializeAsync()
        {
            await UpdateViewAsync();
            await base.InitializeAsync();
        }

        private async Task UpdateViewAsync()
        {
            NumberOfPlayer = await _playerHttpService.GetNumberOfPlayerAsync();
        }
    }
}
