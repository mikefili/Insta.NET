using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstaDOTNET.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "Author", "Caption", "Name", "URL" },
                values: new object[,]
                {
                    { 1, "Mike F.", "This is the first test image", "Image One", "https://via.placeholder.com/200" },
                    { 2, "Mike F.", "This is the second test image", "Image Two", "https://via.placeholder.com/200" },
                    { 3, "Mike F.", "This is the third test image", "Image Three", "https://via.placeholder.com/200" },
                    { 4, "Mike F.", "This is the fourth test image", "Image Four", "https://via.placeholder.com/200" },
                    { 5, "Mike F.", "This is the fifth test image", "Image Five", "https://via.placeholder.com/200" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
