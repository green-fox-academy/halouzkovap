using Microsoft.EntityFrameworkCore.Migrations;

namespace Rascal.Migrations
{
    public partial class UpdateChannels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyChannel_Users_UserId",
                table: "MyChannel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyChannel",
                table: "MyChannel");

            migrationBuilder.RenameTable(
                name: "MyChannel",
                newName: "Channels");

            migrationBuilder.RenameIndex(
                name: "IX_MyChannel_UserId",
                table: "Channels",
                newName: "IX_Channels_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Channels",
                table: "Channels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Channels_Users_UserId",
                table: "Channels",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Channels_Users_UserId",
                table: "Channels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Channels",
                table: "Channels");

            migrationBuilder.RenameTable(
                name: "Channels",
                newName: "MyChannel");

            migrationBuilder.RenameIndex(
                name: "IX_Channels_UserId",
                table: "MyChannel",
                newName: "IX_MyChannel_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyChannel",
                table: "MyChannel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyChannel_Users_UserId",
                table: "MyChannel",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
