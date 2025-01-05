using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsVolunteer.Data.Migrations
{
    public partial class onetomeny : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customercastId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_customercastId",
                table: "Applications",
                column: "customercastId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_customers_customercastId",
                table: "Applications",
                column: "customercastId",
                principalTable: "customers",
                principalColumn: "castId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_customers_customercastId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_customercastId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "customercastId",
                table: "Applications");
        }
    }
}
