using GarageApp.Data.Configurations;
using GarageApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GarageApp.Data
{
    public class GarageDbContext : DbContext
    {
        public GarageDbContext(DbContextOptions<GarageDbContext> options)
            : base(options)
        {
        }
        public DbSet<Garage> Garages { get; set; } = null!;
        public DbSet<Car> Cars { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfiguration());
            modelBuilder.ApplyConfiguration(new GarageConfiguration());

        }

    }

}
