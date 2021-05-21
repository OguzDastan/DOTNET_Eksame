using Microsoft.EntityFrameworkCore.Migrations;

namespace Rema1000.API.Migrations
{
    public partial class DataSeedConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Unit",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Mejeri produkter, såsom mælk, ost, fløde osv.", "Mejeri" },
                    { 2, "Vand, Sodavand, Øl, Energidrikke m.m.", "Læskedrikke" },
                    { 3, "Rugbrød, toastbrød, franskbrød m.m.", "Brød" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Arla mejeri produkter og produktion.", "Arla" },
                    { 2, "Brød, brød og brød.", "Schulstad" },
                    { 3, "Produktion af Sodavand, øl og andre læskedrikke.", "Royal Unibrew" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CategoryId", "Desc", "Name", "Price", "Stock", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { 5, 1, 1, "Mælk du kan drikke.", "Sødmælk", 8.9499999999999993, 100, 1, 1.0 },
                    { 6, 1, 1, "Ost til din madpakke.", "Ost", 22.949999999999999, 300, 1, 0.20000000000000001 },
                    { 7, 1, 2, "Kakao du kan drikke.", "Kakao", 16.949999999999999, 500, 1, 1.0 },
                    { 8, 1, 3, "Nyt fra Arla, de kan også lave brød!", "Arla Brød", 24.949999999999999, 50, 1, 1.0 },
                    { 3, 1, 3, "Rugbrød med store kerner.", "Rugbrød", 11.949999999999999, 50, 2, 0.20000000000000001 },
                    { 4, 1, 3, "Sundt brød!", "Sandwhichbrød", 20.949999999999999, 25, 2, 0.5 },
                    { 1, 1, 2, "Sukkerfri Cola!", "Pepsi Max", 15.949999999999999, 500, 3, 1.5 },
                    { 2, 6, 2, "Øl med 1.5% alkohol!", "Heineken", 36.950000000000003, 150, 3, 0.33000000000000002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Unit",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
