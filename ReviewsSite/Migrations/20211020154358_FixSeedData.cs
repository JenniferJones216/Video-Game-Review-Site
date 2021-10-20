using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class FixSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                column: "PlatformId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoGamePlatforms",
                keyColumn: "Id",
                keyValue: 6,
                column: "PlatformId",
                value: 1);
        }
    }
}
