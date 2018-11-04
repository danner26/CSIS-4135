using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab06.Migrations
{
    public partial class ReviewUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MovieTitle",
                table: "Review",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieTitle",
                table: "Review");
        }
    }
}
