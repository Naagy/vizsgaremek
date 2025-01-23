using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService;
using System;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.ControlPanel
{
    public class ControlPanelViewModel: BaseViewModel
    {
        private readonly IStudentHttpService _studentHttpService;

        public ControlPanelViewModel()
        {
            _studentHttpService = new StudentHttpService();
        }
        public ControlPanelViewModel(IStudentHttpService? studentHttpService)
        {
            _studentHttpService=studentHttpService ?? throw new ArgumentException(nameof(studentHttpService));
        }

        public async override Task InitializeAsync()
        {
            await UpdateViewAsync();
            await base.InitializeAsync();
        }

        private async Task UpdateViewAsync()
        {
            throw new NotImplementedException();
        }
    }
}
