using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketProject.Migrations
{
    public partial class TaskProj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContractType",
                table: "PartnerCompanies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractType",
                table: "PartnerCompanies");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Categories");
        }
    }
}
