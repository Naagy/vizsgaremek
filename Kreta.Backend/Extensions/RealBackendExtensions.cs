using Real.Backend.Context;
using Real.Backend.Repos;
using Real.Shared.Assamblers;
using Real.Shared.Assemblers;
using Microsoft.EntityFrameworkCore;

namespace Real.Backend.Extensions
{
    public static class RealBackendExtensions
    {
        public static void AddBackend(this IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureInMemoryContext();
            services.ConfigureRepos();
            services.ConfigureAssamblers();
        }
        private static void ConfigureCors(this IServiceCollection services)
        {

            services.AddCors(option =>
                 option.AddPolicy(name: "RealCors",
                     policy =>
                     {
                         policy.WithOrigins("https://localhost:7090/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }

        private static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameRealContext = "Real" + Guid.NewGuid();
            services.AddDbContext<RealContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameRealContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );


            string dbNameInMemoryContext = "Real" + Guid.NewGuid();
            services.AddDbContext<RealInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }

        private static void ConfigureRepos(this IServiceCollection services) 
        { 
            services.AddScoped<IPlayerRepo, PlayerRepo<RealInMemoryContext>>();
            services.AddScoped<ISubjectRepo, SubjectRepo<RealInMemoryContext>>();

        }

        private static void ConfigureAssamblers(this IServiceCollection services)
        {
            services.AddScoped<PlayerAssembler>();
            services.AddScoped<SubjectAssambler>();
        }
    }
}
