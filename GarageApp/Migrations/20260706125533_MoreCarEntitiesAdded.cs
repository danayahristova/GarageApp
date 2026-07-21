using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GarageApp.Migrations
{
    /// <inheritdoc />
    public partial class MoreCarEntitiesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsAvailable", "Make", "Model" },
                values: new object[] { false, "Toyota", "Corolla" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[] { true, "Ford", "Focus", 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Make", "Model", "Type", "Year" },
                values: new object[] { "Mercedes-Benz", "C-Class", 0, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[] { true, "Honda", "Civic", 0, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[] { false, "Volkswagen", "Golf", 1, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Make", "Model", "Year" },
                values: new object[] { "Kia", "Sportage", 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IsAvailable", "Make", "Model", "Year" },
                values: new object[] { true, "Mazda", "Mazda3", 2019 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "GarageId", "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[,]
                {
                    { 11, 3, true, "Nissan", "Altima", 0, 2020 },
                    { 12, 3, true, "Subaru", "Outback", 2, 2019 },
                    { 13, 3, false, "Chevrolet", "Malibu", 0, 2018 },
                    { 14, 3, true, "Tesla", "Model 3", 0, 2022 },
                    { 15, 3, true, "Volvo", "XC60", 2, 2021 },
                    { 16, 4, true, "Audi", "Q5", 2, 2020 },
                    { 17, 4, true, "BMW", "3 Series", 0, 2019 },
                    { 18, 4, false, "Ford", "Escape", 2, 2021 },
                    { 19, 4, true, "Toyota", "RAV4", 2, 2022 },
                    { 20, 4, true, "Honda", "Accord", 0, 2020 },
                    { 21, 5, true, "Mercedes-Benz", "GLA", 2, 2021 },
                    { 22, 5, false, "Volkswagen", "Passat", 0, 2019 },
                    { 23, 5, true, "Hyundai", "Elantra", 0, 2022 },
                    { 24, 5, true, "Kia", "Sorento", 2, 2020 },
                    { 25, 5, true, "Mazda", "CX-5", 2, 2021 },
                    { 26, 6, true, "Nissan", "Qashqai", 2, 2019 },
                    { 27, 6, true, "Subaru", "Forester", 2, 2020 },
                    { 28, 6, false, "Chevrolet", "Cruze", 0, 2018 },
                    { 29, 6, true, "Tesla", "Model Y", 2, 2023 },
                    { 30, 6, true, "Volvo", "S60", 0, 2021 },
                    { 31, 7, true, "Audi", "A6", 0, 2019 },
                    { 32, 7, true, "BMW", "X3", 2, 2022 },
                    { 33, 7, false, "Ford", "Fiesta", 1, 2017 },
                    { 34, 7, true, "Toyota", "Camry", 0, 2021 },
                    { 35, 7, true, "Honda", "CR-V", 2, 2022 },
                    { 36, 8, true, "Mercedes-Benz", "E-Class", 0, 2020 },
                    { 37, 8, true, "Volkswagen", "Tiguan", 2, 2021 },
                    { 38, 8, false, "Hyundai", "i30", 1, 2019 },
                    { 39, 8, true, "Kia", "Rio", 1, 2020 },
                    { 40, 8, true, "Mazda", "6", 0, 2018 },
                    { 41, 9, true, "Nissan", "Juke", 2, 2021 },
                    { 42, 9, true, "Subaru", "Impreza", 0, 2020 },
                    { 43, 9, false, "Chevrolet", "Equinox", 2, 2022 },
                    { 44, 9, true, "Tesla", "Model S", 0, 2023 },
                    { 45, 9, true, "Volvo", "XC40", 2, 2021 },
                    { 46, 10, true, "Audi", "Q3", 2, 2022 },
                    { 47, 10, true, "BMW", "5 Series", 0, 2020 },
                    { 48, 10, false, "Ford", "Kuga", 2, 2021 },
                    { 49, 10, true, "Toyota", "Yaris", 1, 2019 },
                    { 50, 10, true, "Honda", "Jazz", 1, 2018 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsAvailable", "Make", "Model" },
                values: new object[] { true, "Mercedes-Benz", "C-Class" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[] { false, "Toyota", "Corolla", 0, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Make", "Model", "Type", "Year" },
                values: new object[] { "Ford", "Focus", 1, 2017 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[] { false, "VW", "Golf", 1, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[] { true, "Honda", "Civic", 0, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Make", "Model", "Year" },
                values: new object[] { "Nissan", "Qashqai", 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IsAvailable", "Make", "Model", "Year" },
                values: new object[] { false, "Skoda", "Octavia", 2018 });
        }
    }
}
