using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DBMigration_test.Context
{
    public class MigrationContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Studentcs> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =LAPTOP-30KT0O04\SQLEXPRESS; Database = DBMigration;Trusted_Connection=True;");
        }
    }

  
}
