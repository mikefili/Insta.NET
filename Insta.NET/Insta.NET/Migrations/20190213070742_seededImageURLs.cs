using Microsoft.EntityFrameworkCore.Migrations;

namespace InstaDOTNET.Migrations
{
    public partial class seededImageURLs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "https://via.placeholder.com/200");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "https://via.placeholder.com/200");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "https://via.placeholder.com/200");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "https://via.placeholder.com/200");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 5,
                column: "URL",
                value: "https://via.placeholder.com/200");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1,
                column: "URL",
                value: "image_one.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2,
                column: "URL",
                value: "image_two.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 3,
                column: "URL",
                value: "image_three.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 4,
                column: "URL",
                value: "image_four.png");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 5,
                column: "URL",
                value: "image_five.png");
        }
    }
}
