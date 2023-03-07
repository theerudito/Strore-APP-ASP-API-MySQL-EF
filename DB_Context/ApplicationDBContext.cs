using Microsoft.EntityFrameworkCore;
using Strore_APP_ASP_API_MySQL.Models;
using System.Reflection;

namespace Strore_APP_ASP_API_MySQL.DB_Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<MAuth> Auth => Set<MAuth>();
        public DbSet<MCart> Cart => Set<MCart>();
        public DbSet<MClient> Clients => Set<MClient>();
        public DbSet<MCodeApp> CodeApp => Set<MCodeApp>();
        public DbSet<MCompany> Company => Set<MCompany>();
        public DbSet<MDetailsCart> DetailCart => Set<MDetailsCart>();
        public DbSet<MProduct> Products => Set<MProduct>();
        public DbSet<MReport> Reports => Set<MReport>();
    }
}
