using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddedRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rating",
                value: 3.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "Rating",
                value: 4.5);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "Rating",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "Rating",
                value: 4.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "Rating",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "Rating",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "Rating",
                value: 1.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "Rating",
                value: 3.5);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "Rating",
                value: 4.2000000000000002);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "Rating",
                value: 4.5);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "Rating",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "Rating",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "Rating",
                value: 4.5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "Rating",
                value: 3.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                column: "Rating",
                value: 0.0);
        }
    }
}
