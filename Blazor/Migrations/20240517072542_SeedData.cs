using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "weathers",
                columns: new[] { "id", "city", "latitude", "longitude" },
                values: new object[] { 2, "New York", 50f, -56f });

            migrationBuilder.InsertData(
                table: "weathers",
                columns: new[] { "id", "city", "latitude", "longitude" },
                values: new object[] { 3, "Kuala Lumpur", 34f, -43f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "weathers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "weathers",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
