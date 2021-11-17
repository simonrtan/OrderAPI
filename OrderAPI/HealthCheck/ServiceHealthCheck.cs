using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OrderAPI.HealthCheck
{
    public static class ServiceHealthCheck
    {
        public static IServiceCollection AddServiceHealthChecks(this IServiceCollection services, IConfiguration configuration)
        {
            var databaseConnection = configuration.GetConnectionString("Database");
            services.AddHealthChecks()
                .AddNpgSql(databaseConnection);

            return services;
        }
    }
}
