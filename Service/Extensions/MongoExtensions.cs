using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace Service.Extensions
{
    public static class MongoExtensions
    {
        public static IServiceCollection AddMongoService(this IServiceCollection services, string connectionString)
        {
            services = services
                .AddSingleton<IMongoClient>(provider =>
                {
                    var settings = MongoClientSettings.FromConnectionString(connectionString);
                    settings.ConnectTimeout = TimeSpan.FromSeconds(2);

                    var client = new MongoClient(settings);
                    return client;
                })
                .AddScoped<IThreadContentService, ThreadContentService>();

            return services;
        }
    }
}
