using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicShop.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shoes",
                columns: new[] { "Id", "Description", "Name", "Price", "QuantityOfStock" },
                values: new object[,]
                {
                    { 1, "Nike running shoes for every day sport", "Running shoes", 1000m, 5 },
                    { 2, "Some HP printer that will print pages", "Printer", 3000m, 2 },
                    { 3, "0,5 standart coke", "Coca-cola", 25m, 0 },
                    { 4, "Chicken with fried rice and wokin", "Wokin", 119m, 100 },
                    { 5, "Blue with a corgi on bike", "T-shirt", 300m, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shoes",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
