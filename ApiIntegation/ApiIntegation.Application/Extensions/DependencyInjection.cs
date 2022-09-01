using ApiIntegation.Application.Commands.ApiIntegration;
using ApiIntegation.Client.Bradesco.Config;
using ApiIntegation.Client.Itau.Config;
using ApiIntegation.Client.Santander.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace ApiIntegation.Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IApiIntegrationCommand, ApiIntegrationCommand>();
            return services;
        }

        public static void AddBradescoClient(this IServiceCollection services, IConfiguration configuration)
        {
            var sectionConfig = configuration.GetSection(nameof(ClientBradescoConfiguration));
            if (sectionConfig is not null)
            {
                services.AddTransient<IClientBradescoConfiguration, ClientBradescoConfiguration>(_ =>
                    _.GetRequiredService<IOptions<ClientBradescoConfiguration>>().Value);
            }
        }

        public static void AddItauClient(this IServiceCollection services, IConfiguration configuration)
        {
            var sectionConfig = configuration.GetSection(nameof(ClientItauConfiguration));
            if (sectionConfig is not null)
            {
                services.AddTransient<IClientItauConfiguration, ClientItauConfiguration>(_ =>
                    _.GetRequiredService<IOptions<ClientItauConfiguration>>().Value);
            }
        }

        public static void AddSantanderClient(this IServiceCollection services, IConfiguration configuration)
        {
            var sectionConfig = configuration.GetSection(nameof(ClientSantanderConfiguration));
            if (sectionConfig is not null)
            {
                services.AddTransient<IClientSantanderConfiguration, ClientSantanderConfiguration>(_ =>
                    _.GetRequiredService<IOptions<ClientSantanderConfiguration>>().Value);
            }
        }


    }

}
