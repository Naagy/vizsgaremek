using Real.Desktop.ViewModels;
using Real.Desktop.ViewModels.ControlPanel;
using Real.Desktop.ViewModels.Login;
using Real.Desktop.ViewModels.RealCitizens;
using Real.Desktop.Views;
using Real.Desktop.Views.ControlPanel;
using Real.Desktop.Views.Login;
using Real.Desktop.Views.RealCitizens;
using Microsoft.Extensions.DependencyInjection;

namespace RealDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // Real Citizens
            services.AddSingleton<RealCitizensViewModel>();
            services.AddSingleton<RealCitizensView>(s => new RealCitizensView()
            {
                DataContext = s.GetRequiredService<RealCitizensViewModel>()
            });

            // Players
            // Real Citizens
            services.AddSingleton<PlayerViewModel>();
            services.AddSingleton<PlayerView>(s => new PlayerView()
            {
                DataContext = s.GetRequiredService<PlayerViewModel>()
            });

        }
    }
}
