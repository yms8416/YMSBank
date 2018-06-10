using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BilgeAdam.YMSBank.Data.Migrations
{
    public partial class ModuleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header",
                schema: "Enterprise",
                table: "Menus");

            migrationBuilder.AddColumn<long>(
                name: "ModuleId",
                schema: "Enterprise",
                table: "Menus",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Updated = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ModuleId",
                schema: "Enterprise",
                table: "Menus",
                column: "ModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Modules_ModuleId",
                schema: "Enterprise",
                table: "Menus",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Modules_ModuleId",
                schema: "Enterprise",
                table: "Menus");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Menus_ModuleId",
                schema: "Enterprise",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ModuleId",
                schema: "Enterprise",
                table: "Menus");

            migrationBuilder.AddColumn<string>(
                name: "Header",
                schema: "Enterprise",
                table: "Menus",
                maxLength: 30,
                nullable: true);
        }
    }
}
