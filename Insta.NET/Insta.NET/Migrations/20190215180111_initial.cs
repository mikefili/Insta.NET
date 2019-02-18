using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstaDOTNET.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageID = table.Column<int>(nullable: false),
                    CommentString = table.Column<string>(nullable: false),
                    CommentAuthor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Caption = table.Column<string>(nullable: false),
                    URL = table.Column<string>(nullable: false),
                    CommentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Comments_CommentID",
                        column: x => x.CommentID,
                        principalTable: "Comments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "Author", "Caption", "CommentID", "Name", "URL" },
                values: new object[,]
                {
                    { 1, "Mike F.", "This is the first test image", null, "Image One", "https://via.placeholder.com/200" },
                    { 2, "Mike F.", "This is the second test image", null, "Image Two", "https://via.placeholder.com/200" },
                    { 3, "Mike F.", "This is the third test image", null, "Image Three", "https://via.placeholder.com/200" },
                    { 4, "Mike F.", "This is the fourth test image", null, "Image Four", "https://via.placeholder.com/200" },
                    { 5, "Mike F.", "This is the fifth test image", null, "Image Five", "https://via.placeholder.com/200" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CommentID",
                table: "Images",
                column: "CommentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
