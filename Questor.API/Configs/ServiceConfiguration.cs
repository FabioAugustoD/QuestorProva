using Questor.API.Services;
using Questor.Infra.Interfaces;
using Questor.Infra.Repositories;

namespace Questor.API.Configs
{
    public class ServiceConfiguration
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            AddServices(serviceProvider);
        }

        private static void AddServices(IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<IBancoRepository, BancoRepository>();
            serviceProvider.AddScoped<IBancoService, BancoService>();
           //serviceProvider.AddScoped<IBoletoRepository, BoletoRepository>();
           //serviceProvider.AddScoped<IBoletoService, BoletoService>();
        }
    }
}
