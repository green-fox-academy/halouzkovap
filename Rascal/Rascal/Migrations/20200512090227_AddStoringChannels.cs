using Microsoft.EntityFrameworkCore.Migrations;

namespace Rascal.Migrations
{
    public partial class AddStoringChannels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyChannel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFromApi = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Descripiton = table.Column<string>(nullable: true),
                    Admin = table.Column<string>(nullable: true),
                    Secret = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyChannel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyChannel_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyChannel_UserId",
                table: "MyChannel",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyChannel");
        }
    }
}
