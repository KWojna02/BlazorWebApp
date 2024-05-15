using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorTask2.Migrations
{
    /// <inheritdoc />
    public partial class ClassUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfRates",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "SumOfRates",
                table: "Movie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfRates",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SumOfRates",
                table: "Movie",
                type: "int",
                nullable: true);
        }
    }
}
