using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BilgeAdam.YMSBank.Data.Migrations
{
    public partial class MenuparentIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Menus_ParentId",
                schema: "Enterprise",
                table: "Menus");

            migrationBuilder.AlterColumn<long>(
                name: "ParentId",
                schema: "Enterprise",
                table: "Menus",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Menus_ParentId",
                schema: "Enterprise",
                table: "Menus",
                column: "ParentId",
                principalSchema: "Enterprise",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Menus_ParentId",
                schema: "Enterprise",
                table: "Menus");

            migrationBuilder.AlterColumn<long>(
                name: "ParentId",
                schema: "Enterprise",
                table: "Menus",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Menus_ParentId",
                schema: "Enterprise",
                table: "Menus",
                column: "ParentId",
                principalSchema: "Enterprise",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
