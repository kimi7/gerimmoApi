using Microsoft.EntityFrameworkCore;

namespace gerimmoApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<OwnerProperty> OwnerProperties{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }
    }
}