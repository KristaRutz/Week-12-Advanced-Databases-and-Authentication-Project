using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookClub.Migrations
{
    public partial class YearToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PublicationYear",
                table: "Books",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublicationYear",
                table: "Books",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
