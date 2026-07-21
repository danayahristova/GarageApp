using GarageApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace GarageApp.Data.Configurations
{
    public class GarageConfiguration : IEntityTypeConfiguration<Garage>
    {
        public void Configure(EntityTypeBuilder<Garage> builder)
        {
             builder.ToTable("Garages");

             builder.HasKey(g => g.Id);

             builder.Property(g => g.Name)
                    .IsRequired()
                    .HasMaxLength(50);
             builder.Property(g => g.Location)
                    .IsRequired()
                    .HasMaxLength(50);

            builder.HasData(
                new Garage
                {
                    Id = 1,
                    Name = "Central Garage",
                    Location = "Sofia"
                },
                new Garage
                {
                    Id = 2,
                    Name = "Mountain Garage",
                    Location = "Plovdiv"
                },

                new Garage
                {
                    Id = 3,
                    Name = "East Garage",
                    Location = "Varna"
                },
                new Garage
                {
                    Id = 4,
                    Name = "West Garage",
                    Location = "Burgas"
                },
                new Garage
                {
                    Id = 5,
                    Name = "North Garage",
                    Location = "Ruse"
                },
                new Garage
                {
                    Id = 6,
                    Name = "South Garage",
                    Location = "Stara Zagora"
                },
                new Garage
                {
                    Id = 7,
                    Name = "Lakeside Garage",
                    Location = "Pleven"
                },
                new Garage
                {
                    Id = 8,
                    Name = "Valley Garage",
                    Location = "Veliko Tarnovo"
                },
                new Garage
                {
                    Id = 9,
                    Name = "Highway Garage",
                    Location = "Blagoevgrad"
                },
                new Garage
                {
                    Id = 10,
                    Name = "Riverside Garage",
                    Location = "Dobrich"
                }
            );
        }
    }
}
