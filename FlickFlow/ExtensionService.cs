using FlickFlow.Data;
using Microsoft.EntityFrameworkCore;
using System;


namespace FlickFlow
{
    public static class ExtensionService
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConn")));            
        }


        //Seed database
        public static void SeedDataBase(this IApplicationBuilder app)
        {
            AppDbInitializer.Seed(app);
        }

    }
}

