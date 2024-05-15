using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorTask2.Migrations
{
    /// <inheritdoc />
    public partial class ClassUpdate4 : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Movie");

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
