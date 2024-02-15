using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbpUserImport.Migrations
{
    public partial class AddImportUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImportUserId",
                table: "AbpUsers",
                type: "uniqueidentifier",
                maxLength: 36,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImportUserId",
                table: "AbpUsers");
        }
    }
}
