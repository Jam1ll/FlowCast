using FlowCast.Core.Domain.Interfaces;
using FlowCast.Infrastructure.Persistence.Contexts;
using FlowCast.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace FlowCast.Infrastructure.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddPersistenceLayerIoC(this IServiceCollection services, IConfiguration config)
        {
            #region contexts

            if (config.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<FlowCastContext>(opt =>
                                              opt.UseInMemoryDatabase("AppDb"));
            }
            else
            {
                var connectionString = config.GetConnectionString("DefaultConnection");
                services.AddDbContext<FlowCastContext>(
                    (serviceProvider, opt) =>
                    {
                        opt.EnableSensitiveDataLogging();
                        opt.UseSqlServer(connectionString,
                        m => m.MigrationsAssembly(typeof(FlowCastContext).Assembly.FullName));
                    },
                    contextLifetime: ServiceLifetime.Scoped,
                    optionsLifetime: ServiceLifetime.Scoped
                    );

                #endregion

                #region repositories IoC

                services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                services.AddScoped<IPredictionDataRepository, PredictionDataRepository>();
                services.AddScoped<IPredictionResultsRepository, PredictionResultsRepository>();

                #endregion

            }
        }
    }
}
