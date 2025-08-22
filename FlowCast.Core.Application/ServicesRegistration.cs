using FlowCast.Core.Application.Interfaces;
using FlowCast.Core.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FlowCast.Core.Application
{
    public static class ServicesRegistration
    {
        // extension method - decorator pattern

        public static void AddApplicationLayerIoc(this IServiceCollection services)
        {
            #region configurations

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(opt => opt.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            
            #endregion

            #region Services IoC

            services.AddScoped<IPredictionDataService, PredictionDataService>();
            services.AddScoped<IPredictionResultsService, PredictionResultsService>();
            
            #endregion
        }
    }
}
