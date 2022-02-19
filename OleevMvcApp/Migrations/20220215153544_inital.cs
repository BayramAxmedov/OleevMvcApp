using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OleevMvcApp.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sectionEights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionEights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionFives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubHeader2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Customer2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionFives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionFours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryHeader1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription1 = table.Column<int>(type: "int", nullable: false),
                    CategoryIcon1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryHeader2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription2 = table.Column<int>(type: "int", nullable: false),
                    CategoryIcon2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionFours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionOnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionOnes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionSevens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item1Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item1Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item1Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Item1Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionSevens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionSixes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryIcon1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryIcon2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionSixes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionThrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionThrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectionTwos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionTwos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sectionEights");

            migrationBuilder.DropTable(
                name: "SectionFives");

            migrationBuilder.DropTable(
                name: "SectionFours");

            migrationBuilder.DropTable(
                name: "SectionOnes");

            migrationBuilder.DropTable(
                name: "SectionSevens");

            migrationBuilder.DropTable(
                name: "SectionSixes");

            migrationBuilder.DropTable(
                name: "SectionThrees");

            migrationBuilder.DropTable(
                name: "SectionTwos");
        }
    }
}
