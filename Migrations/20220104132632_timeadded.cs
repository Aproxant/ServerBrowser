using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServerBrowser.Migrations
{
    public partial class timeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "lastActive",
                table: "ServerList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lastActive",
                table: "ServerList");
        }
    }
}
