using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GarageApp.Migrations
{
    /// <inheritdoc />
    public partial class MoreDataAddedToTheDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GarageId", "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[] { 1, true, "Mercedes-Benz", "C-Class", 0, 2020 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "GarageId", "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[,]
                {
                    { 4, 1, false, "Toyota", "Corolla", 0, 2019 },
                    { 5, 1, true, "Ford", "Focus", 1, 2017 },
                    { 6, 2, false, "VW", "Golf", 1, 2014 },
                    { 7, 2, true, "Honda", "Civic", 0, 2021 },
                    { 8, 2, true, "Hyundai", "Tucson", 2, 2022 },
                    { 9, 2, true, "Nissan", "Qashqai", 2, 2020 },
                    { 10, 2, false, "Skoda", "Octavia", 0, 2018 }
                });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 3, "Varna", "East Garage" },
                    { 4, "Burgas", "West Garage" },
                    { 5, "Ruse", "North Garage" },
                    { 6, "Stara Zagora", "South Garage" },
                    { 7, "Pleven", "Lakeside Garage" },
                    { 8, "Veliko Tarnovo", "Valley Garage" },
                    { 9, "Blagoevgrad", "Highway Garage" },
                    { 10, "Dobrich", "Riverside Garage" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Garages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GarageId", "IsAvailable", "Make", "Model", "Type", "Year" },
                values: new object[] { 2, false, "VW", "Golf", 1, 2014 });
        }
    }
}
