using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Lead",
                type: "text",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Lead",
                type: "text",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Lead",
                type: "text",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Consorcio",
                table: "Lead",
                type: "text",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Lead",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Lead",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Lead",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Consorcio",
                table: "Lead",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 30);
        }
    }
}
