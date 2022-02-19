using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OleevMvcApp.Migrations
{
    public partial class Oleev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "sectionEights",
                newName: "Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "SectionTwos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "SectionThrees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "SectionSixes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "SectionSevens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "SectionOnes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "SectionFours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "SectionFives",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "sectionEights",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "SectionTwos");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "SectionThrees");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "SectionSixes");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "SectionSevens");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "SectionOnes");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "SectionFours");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "SectionFives");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "sectionEights");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "sectionEights",
                newName: "MyProperty");
        }
    }
}
