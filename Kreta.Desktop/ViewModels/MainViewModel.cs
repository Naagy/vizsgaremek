using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using Real.Desktop.ViewModels.Base;
using Real.Desktop.ViewModels.ControlPanel;
using Real.Desktop.ViewModels.RealCitizens;
using System.Threading.Tasks;

namespace Real.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private RealCitizensViewModel _realCitizensViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _realCitizensViewModel = new RealCitizensViewModel();
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            RealCitizensViewModel realCitizensViewModel
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _realCitizensViewModel = realCitizensViewModel;

            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public async Task ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.SolarPanel;
            await _controlPanelViewModel.InitializeAsync();
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowRealCitizens()
        {
            Caption = "Csapat";
            Icon = IconChar.UserGroup;
            CurrentChildView = _realCitizensViewModel;
        }
    }
}
