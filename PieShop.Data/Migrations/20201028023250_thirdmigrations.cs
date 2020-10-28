using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Data.Migrations
{
    public partial class thirdmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Salary = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    RequiredSkills = table.Column<string>(nullable: true),
                    DegreeRequirements = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 10, 28, 8, 32, 48, 23, DateTimeKind.Local).AddTicks(5267));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 10, 27, 4, 54, 48, 213, DateTimeKind.Local).AddTicks(7736));
        }
    }
}
