using Microsoft.EntityFrameworkCore.Migrations;

namespace BankOfSimba.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AnimalType", "Balance", "Name" },
                values: new object[] { 6, "person", 500m, "King" });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AnimalType", "Balance", "Name" },
                values: new object[] { 7, "person", 500m, "Bad Guy" });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AnimalType", "Balance", "Name" },
                values: new object[] { 8, "person", 500m, "Good Guy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
