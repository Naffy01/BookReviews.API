using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviews.API.Migrations
{
    public partial class Student_Updated_Removed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChartType",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DoubleType",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Students",
                newName: "Height");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Height",
                table: "Students",
                newName: "Age");

            migrationBuilder.AddColumn<string>(
                name: "ChartType",
                table: "Students",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "DoubleType",
                table: "Students",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
