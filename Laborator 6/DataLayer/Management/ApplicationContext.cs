using Microsoft.EntityFrameworkCore;

namespace DataLayer.Management
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<CityData.City> Cities { get; set; }
        public DbSet<PoiData.Poi> Pois { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}