using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BilgeAdam.YMSBank.Data.Migrations
{
    public partial class MenuHeaderAddColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Finance",
                table: "Transfers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "UserRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "People",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Header",
                schema: "Enterprise",
                table: "Menus",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Menus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "GenericLookupTypes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "GenericLookups",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Employees",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Account",
                table: "Accounts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Account",
                table: "AccountHistories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Finance",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Header",
                schema: "Enterprise",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "GenericLookupTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "GenericLookups");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Enterprise",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Account",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Account",
                table: "AccountHistories");
        }
    }
}
