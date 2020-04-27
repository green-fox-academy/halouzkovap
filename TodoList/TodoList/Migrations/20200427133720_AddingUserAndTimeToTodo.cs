using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoList.Migrations
{
    public partial class AddingUserAndTimeToTodo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Todos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Inserted",
                table: "Todos",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Todos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Todos_UserId",
                table: "Todos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Users_UserId",
                table: "Todos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Users_UserId",
                table: "Todos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Todos_UserId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "Inserted",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Todos");
        }
    }
}
