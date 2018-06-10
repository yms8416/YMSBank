using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BilgeAdam.YMSBank.Data.Migrations
{
    public partial class ModuleSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Modules",
                newSchema: "Enterprise");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Enterprise",
                table: "Modules",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Modules",
                schema: "Enterprise");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Modules",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);
        }
    }
}
