using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class VideoEmbed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoURL",
                value: "https://www.youtube.com/embed/YV2lp6p_gXw");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoURL",
                value: "https://www.youtube.com/embed/XbQgdSlsd0");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoURL",
                value: "https://www.youtube.com/embed/TluRVBhmf8w");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoURL",
                value: "https://www.youtube.com/embed/iAVh4_wnOIw");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoURL",
                value: "https://www.youtube.com/embed/JSRtYpNRoN0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoURL",
                value: "https://www.youtube.com/watch?v=YV2lp6p_gXw");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoURL",
                value: "https://www.youtube.com/watch?v=-XbQgdSlsd0");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoURL",
                value: "https://www.youtube.com/watch?v=TluRVBhmf8w");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoURL",
                value: "https://www.youtube.com/watch?v=iAVh4_wnOIw");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoURL",
                value: "https://www.youtube.com/watch?v=JSRtYpNRoN0");
        }
    }
}
