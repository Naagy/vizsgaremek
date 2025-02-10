using Real.HttpService;
using Real.Shared.Assamblers;
using Real.Shared.Assemblers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Real.Desktop.Extensions
{
    public static class DesktopExtensions
    {
        public static void AddDesktop(this IServiceCollection services)
        {
            services.ConfigureHttpClient();
            services.ConfigureHttpServices();
            services.ConfigureAssamblers();
        }

        private static void ConfigureHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient("RealApi", configureClient => { configureClient.BaseAddress = new Uri("https://localhost:7090/"); });
        }

        private static void ConfigureHttpServices(this IServiceCollection services)
        {
            services.AddScoped<IPlayerHttpService, PlayerHttpService>();
            services.AddScoped<ISubjectHttpService, SubjectHttpService>();
        }

        private static void ConfigureAssamblers(this IServiceCollection services)
        {
            {
                services.AddScoped<PlayerAssembler>();
                services.AddScoped<SubjectAssambler>();
            }
        }
    }
}