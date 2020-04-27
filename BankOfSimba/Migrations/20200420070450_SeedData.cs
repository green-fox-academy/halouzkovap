using Microsoft.EntityFrameworkCore.Migrations;

namespace BankOfSimba.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AnimalType", "Balance", "Name" },
                values: new object[,]
                {
                    { 1, "lion", 2000m, "Simba" },
                    { 2, "elephant", 5000m, "Hathi" },
                    { 3, "wolf", 6000m, "Akela" },
                    { 4, "bear", 1000m, "Balu" },
                    { 5, "snike", 500m, "Ka" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
