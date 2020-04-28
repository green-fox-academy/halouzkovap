using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoList.Migrations
{
    public partial class Update_Tables_and_naming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Todos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueAt",
                table: "Todos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "DueAt",
                table: "Todos");
        }
    }
}
