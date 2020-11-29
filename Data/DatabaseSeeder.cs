using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Foodcom.Models;

namespace Foodcom.Data
{
    public class DatabaseSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                new DatabaseContext(serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                context.Database.EnsureCreated();

                if (!context.Config.Any())
                {
                    context.Config.AddRange(new[]
                    {
                        Config.Make("database_version", "0.0.0"),
                        Config.Make("app_name", "foodcom"),
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}