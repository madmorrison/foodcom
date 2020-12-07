using foodcom.Models;
using Microsoft.EntityFrameworkCore;

namespace foodcom.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Config> Config { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
    }
}