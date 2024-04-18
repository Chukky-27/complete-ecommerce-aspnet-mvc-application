using FlickFlow.Data;
using Microsoft.EntityFrameworkCore;

namespace FlickFlow
{
    public static class ExtensionService
    {
        public static void AddDependencies(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration
            .GetConnectionString("DefaultConn")));
        }
    } 
}
