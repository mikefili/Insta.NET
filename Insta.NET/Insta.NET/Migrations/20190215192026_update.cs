using Microsoft.EntityFrameworkCore.Migrations;

namespace InstaDOTNET.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Images",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "URL",
                table: "Images",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
