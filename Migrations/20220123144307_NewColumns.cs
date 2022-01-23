using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerBrowser.Migrations
{
    public partial class NewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Mode",
                table: "ServerList",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "playerNumber",
                table: "ServerList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mode",
                table: "ServerList");

            migrationBuilder.DropColumn(
                name: "playerNumber",
                table: "ServerList");
        }
    }
}
