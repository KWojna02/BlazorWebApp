using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorTask2.Migrations
{
    /// <inheritdoc />
    public partial class ANotherClassUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfRates",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfRates",
                table: "Movie");
        }
    }
}
