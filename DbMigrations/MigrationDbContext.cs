using Microsoft.EntityFrameworkCore;

namespace DbMigrations
{
    public class MigrationDbContext : DbContext
    {
        public MigrationDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
