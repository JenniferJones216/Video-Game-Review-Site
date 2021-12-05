using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class _1videolink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoURL",
                value: "https://www.youtube.com/embed/YV2lp6p_gXw");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoURL",
                value: "https://www.youtube.com/watch?v=YV2lp6p_gXw");
        }
    }
}
