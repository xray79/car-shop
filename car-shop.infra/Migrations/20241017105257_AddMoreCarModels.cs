using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace car_shop.infra.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreCarModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Make", "Model", "Price", "Stock" },
                values: new object[,]
                {
                    { 2, "Audi", "A4", 28000.0, 15 },
                    { 3, "Mercedes-Benz", "C-Class", 32000.0, 8 },
                    { 4, "Tesla", "Model 3", 40000.0, 12 },
                    { 5, "Ford", "Mustang", 35000.0, 6 },
                    { 6, "Honda", "Civic", 22000.0, 20 },
                    { 7, "Toyota", "Corolla", 21000.0, 18 },
                    { 8, "Volkswagen", "Golf", 25000.0, 14 },
                    { 9, "Chevrolet", "Camaro", 37000.0, 5 },
                    { 10, "Nissan", "Altima", 23000.0, 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
