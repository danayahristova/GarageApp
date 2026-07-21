using GarageApp.Data.Enums;
using GarageApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GarageApp.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Make)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Model)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Type)
                .IsRequired()
                .HasMaxLength(50);


            // Seed data
            builder.HasData(
                new Car { Id = 1, Make = "Audi", Model = "A4", Year = 2016, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 1 },
                new Car { Id = 2, Make = "BMW", Model = "X5", Year = 2018, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 1 },
                new Car { Id = 3, Make = "Toyota", Model = "Corolla", Year = 2020, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = false, GarageId = 1 },
                new Car { Id = 4, Make = "Ford", Model = "Focus", Year = 2017, Type = Enum.Parse<CarType>("Hatchback"), IsAvailable = true, GarageId = 1 },
                new Car { Id = 5, Make = "Mercedes-Benz", Model = "C-Class", Year = 2019, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 1 },

                new Car { Id = 6, Make = "Honda", Model = "Civic", Year = 2021, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 2 },
                new Car { Id = 7, Make = "Volkswagen", Model = "Golf", Year = 2018, Type = Enum.Parse<CarType>("Hatchback"), IsAvailable = false, GarageId = 2 },
                new Car { Id = 8, Make = "Hyundai", Model = "Tucson", Year = 2022, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 2 },
                new Car { Id = 9, Make = "Kia", Model = "Sportage", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 2 },
                new Car { Id = 10, Make = "Mazda", Model = "Mazda3", Year = 2019, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 2 },

                new Car { Id = 11, Make = "Nissan", Model = "Altima", Year = 2020, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 3 },
                new Car { Id = 12, Make = "Subaru", Model = "Outback", Year = 2019, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 3 },
                new Car { Id = 13, Make = "Chevrolet", Model = "Malibu", Year = 2018, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = false, GarageId = 3 },
                new Car { Id = 14, Make = "Tesla", Model = "Model 3", Year = 2022, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 3 },
                new Car { Id = 15, Make = "Volvo", Model = "XC60", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 3 },

                new Car { Id = 16, Make = "Audi", Model = "Q5", Year = 2020, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 4 },
                new Car { Id = 17, Make = "BMW", Model = "3 Series", Year = 2019, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 4 },
                new Car { Id = 18, Make = "Ford", Model = "Escape", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = false, GarageId = 4 },
                new Car { Id = 19, Make = "Toyota", Model = "RAV4", Year = 2022, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 4 },
                new Car { Id = 20, Make = "Honda", Model = "Accord", Year = 2020, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 4 },

                new Car { Id = 21, Make = "Mercedes-Benz", Model = "GLA", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 5 },
                new Car { Id = 22, Make = "Volkswagen", Model = "Passat", Year = 2019, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = false, GarageId = 5 },
                new Car { Id = 23, Make = "Hyundai", Model = "Elantra", Year = 2022, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 5 },
                new Car { Id = 24, Make = "Kia", Model = "Sorento", Year = 2020, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 5 },
                new Car { Id = 25, Make = "Mazda", Model = "CX-5", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 5 },

                new Car { Id = 26, Make = "Nissan", Model = "Qashqai", Year = 2019, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 6 },
                new Car { Id = 27, Make = "Subaru", Model = "Forester", Year = 2020, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 6 },
                new Car { Id = 28, Make = "Chevrolet", Model = "Cruze", Year = 2018, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = false, GarageId = 6 },
                new Car { Id = 29, Make = "Tesla", Model = "Model Y", Year = 2023, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 6 },
                new Car { Id = 30, Make = "Volvo", Model = "S60", Year = 2021, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 6 },

                new Car { Id = 31, Make = "Audi", Model = "A6", Year = 2019, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 7 },
                new Car { Id = 32, Make = "BMW", Model = "X3", Year = 2022, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 7 },
                new Car { Id = 33, Make = "Ford", Model = "Fiesta", Year = 2017, Type = Enum.Parse<CarType>("Hatchback"), IsAvailable = false, GarageId = 7 },
                new Car { Id = 34, Make = "Toyota", Model = "Camry", Year = 2021, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 7 },
                new Car { Id = 35, Make = "Honda", Model = "CR-V", Year = 2022, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 7 },

                new Car { Id = 36, Make = "Mercedes-Benz", Model = "E-Class", Year = 2020, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 8 },
                new Car { Id = 37, Make = "Volkswagen", Model = "Tiguan", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 8 },
                new Car { Id = 38, Make = "Hyundai", Model = "i30", Year = 2019, Type = Enum.Parse<CarType>("Hatchback"), IsAvailable = false, GarageId = 8 },
                new Car { Id = 39, Make = "Kia", Model = "Rio", Year = 2020, Type = Enum.Parse<CarType>("Hatchback"), IsAvailable = true, GarageId = 8 },
                new Car { Id = 40, Make = "Mazda", Model = "6", Year = 2018, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 8 },

                new Car { Id = 41, Make = "Nissan", Model = "Juke", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 9 },
                new Car { Id = 42, Make = "Subaru", Model = "Impreza", Year = 2020, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 9 },
                new Car { Id = 43, Make = "Chevrolet", Model = "Equinox", Year = 2022, Type = Enum.Parse<CarType>("SUV"), IsAvailable = false, GarageId = 9 },
                new Car { Id = 44, Make = "Tesla", Model = "Model S", Year = 2023, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 9 },
                new Car { Id = 45, Make = "Volvo", Model = "XC40", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 9 },

                new Car { Id = 46, Make = "Audi", Model = "Q3", Year = 2022, Type = Enum.Parse<CarType>("SUV"), IsAvailable = true, GarageId = 10 },
                new Car { Id = 47, Make = "BMW", Model = "5 Series", Year = 2020, Type = Enum.Parse<CarType>("Sedan"), IsAvailable = true, GarageId = 10 },
                new Car { Id = 48, Make = "Ford", Model = "Kuga", Year = 2021, Type = Enum.Parse<CarType>("SUV"), IsAvailable = false, GarageId = 10 },
                new Car { Id = 49, Make = "Toyota", Model = "Yaris", Year = 2019, Type = Enum.Parse<CarType>("Hatchback"), IsAvailable = true, GarageId = 10 },
                new Car { Id = 50, Make = "Honda", Model = "Jazz", Year = 2018, Type = Enum.Parse<CarType>("Hatchback"), IsAvailable = true, GarageId = 10 }
             );   
        }
    }
}
