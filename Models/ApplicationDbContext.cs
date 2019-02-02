using Microsoft.EntityFrameworkCore;

namespace gerimmoApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<OwnerProperty> OwnerProperties{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer("Data Source=cpld797djq.database.windows.net;Initial Catalog=aspnet-RMT-20151010113945;User ID=Milton;Password=Seillemar75013;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
