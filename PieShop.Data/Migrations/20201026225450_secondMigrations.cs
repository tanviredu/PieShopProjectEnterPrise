using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Data.Migrations
{
    public partial class secondMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 10, 27, 4, 54, 48, 213, DateTimeKind.Local).AddTicks(7736));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 10, 25, 0, 2, 38, 646, DateTimeKind.Local).AddTicks(1352));
        }
    }
}
