using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;

namespace Service.Extensions
{
    public static class PostgreExtensions
    {
        public static IServiceCollection AddPostgreService(this IServiceCollection services, string connectionString)
        {
            services = services.AddScoped<IDbConnection>(provider =>
            {
                var client = new NpgsqlConnection(connectionString);

                return client;
            }).AddScoped<IForumThreadService, ForumThreadService>();

            return services;
        }
    }
}
