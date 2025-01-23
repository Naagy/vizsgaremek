using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService;
using System;

namespace Kreta.Desktop.ViewModels.ControlPanel
{
    public class ControlPanelViewModel: BaseViewModel
    {
        private readonly IStudentHttpService _studentHttpService;
        public ControlPanelViewModel(IStudentHttpService? studentHttpService)
        {
            _studentHttpService=studentHttpService ?? throw new ArgumentException(nameof(studentHttpService));
        }


    }
}
