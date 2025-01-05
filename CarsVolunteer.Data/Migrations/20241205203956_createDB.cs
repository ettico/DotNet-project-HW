using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsVolunteer.Data.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    appId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    custID = table.Column<int>(type: "int", nullable: false),
                    volId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.appId);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    castId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    castName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    castPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    castEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    castAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.castId);
                });

            migrationBuilder.CreateTable(
                name: "volunteers",
                columns: table => new
                {
                    volId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    volName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    volPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carNum = table.Column<int>(type: "int", nullable: false),
                    volDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    volStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteers", x => x.volId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "volunteers");
        }
    }
}
