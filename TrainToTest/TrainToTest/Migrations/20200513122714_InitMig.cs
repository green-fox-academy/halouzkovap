using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainToTest.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UrlAliasers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrlAdress = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    SecretCode = table.Column<int>(nullable: false),
                    HitCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlAliasers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrlAliasers");
        }
    }
}
