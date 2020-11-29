using Foodcom.Models;
using Microsoft.EntityFrameworkCore;

namespace Foodcom.Data
{
    public class DatabaseContext : DbContext
    {
        public DbContext Config { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
    }
}