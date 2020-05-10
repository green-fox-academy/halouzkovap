using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UpdateTodo.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assignees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Todos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    IsUrgent = table.Column<bool>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    DueDate = table.Column<DateTime>(nullable: false),
                    AssigneeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todos_Assignees_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "Assignees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTodos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    IsUrgent = table.Column<bool>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    DueDate = table.Column<DateTime>(nullable: false),
                    TodoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTodos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTodos_Todos_TodoId",
                        column: x => x.TodoId,
                        principalTable: "Todos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignees_UserId",
                table: "Assignees",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubTodos_TodoId",
                table: "SubTodos",
                column: "TodoId");

            migrationBuilder.CreateIndex(
                name: "IX_Todos_AssigneeId",
                table: "Todos",
                column: "AssigneeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubTodos");

            migrationBuilder.DropTable(
                name: "Todos");

            migrationBuilder.DropTable(
                name: "Assignees");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
