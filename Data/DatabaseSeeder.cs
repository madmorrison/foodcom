using System;
using System.Linq;
using foodcom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace foodcom.Data
{
    public class DatabaseSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =    
                new DatabaseContext(serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>())
            )
            {
                context.Database.EnsureCreated();
                
                if (!context.Config.Any())
                {
                    context.Config.AddRange(new []
                    {
                        new Config
                        {
                            Key = "DB_VERSION",
                            Setting = "1.0.0" 
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}