using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstaDOTNET.Migrations
{
    public partial class commentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "Images",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Images_CommentID",
                table: "Images",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Comments_CommentID",
                table: "Images",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Comments_CommentID",
                table: "Images");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Images_CommentID",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "Images");
        }
    }
}
