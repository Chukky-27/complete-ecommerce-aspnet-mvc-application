using FlickFlow.Data;

namespace FlickFlow
{
    public static class ExtensionService
    {
        public static void AddDependencies(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>();
        }
    }
}
