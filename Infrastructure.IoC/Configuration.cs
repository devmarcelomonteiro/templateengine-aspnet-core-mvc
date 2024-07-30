using Application.Interfaces;
using Application.Services;
using Domain.Interface;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IoC
{
    public static class Configuration
    {
        public static IServiceCollection InfrastructureDependencies(this IServiceCollection services)
        {

            services.AddTransient<IDepartamentoRepository, DepartamentoRepository>();
            services.AddTransient<IDepartamentoService, DepartamentoService>();

            return services;
        }
    }
}
