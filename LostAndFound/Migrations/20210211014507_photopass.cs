using Microsoft.EntityFrameworkCore.Migrations;

namespace LostAndFound.Migrations
{
    public partial class photopass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "PhotoPass",
                table: "Item",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Item",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPass",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Item");

        }
    }
}
