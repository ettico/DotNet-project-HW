using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsVolunteer.Data.Migrations
{
    public partial class onetomeny : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "volunteers",
                columns: table => new
                {
                    volId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    volName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    volPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    volDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    volStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_volunteers", x => x.volId);
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
                    castAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolunteerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.castId);
                    table.ForeignKey(
                        name: "FK_customers_volunteers_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "volunteers",
                        principalColumn: "volId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    appId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.appId);
                    table.ForeignKey(
                        name: "FK_Applications_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "castId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CustomerId",
                table: "Applications",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_VolunteerId",
                table: "customers",
                column: "VolunteerId");
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
