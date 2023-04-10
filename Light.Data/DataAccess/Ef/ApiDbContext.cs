using Light.Core.Settings;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Light.Data.DataAccess.Ef
{
    public class ApiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder
                .UseSqlServer(LightSettings.Instance.DatabaseSetting.ApiDbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
