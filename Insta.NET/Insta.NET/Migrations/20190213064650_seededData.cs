using Microsoft.EntityFrameworkCore.Migrations;

namespace InstaDOTNET.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "Author", "Caption", "Name", "URL" },
                values: new object[,]
                {
                    { 1, "Mike F.", "This is the first test image", "Image One", "image_one.png" },
                    { 2, "Mike F.", "This is the second test image", "Image Two", "image_two.png" },
                    { 3, "Mike F.", "This is the third test image", "Image Three", "image_three.png" },
                    { 4, "Mike F.", "This is the fourth test image", "Image Four", "image_four.png" },
                    { 5, "Mike F.", "This is the fifth test image", "Image Five", "image_five.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
