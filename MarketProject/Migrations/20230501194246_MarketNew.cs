using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketProject.Migrations
{
    public partial class MarketNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_CleaningEquipmentWarehouses_CleaningEquipmentWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_ElectronicWarehouses_ElectronicWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_FoodDrinkWarehouses_FoodDrinkWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropTable(
                name: "CleaningEquipmentWarehouses");

            migrationBuilder.DropTable(
                name: "ElectronicWarehouses");

            migrationBuilder.DropTable(
                name: "FoodDrinkWarehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_CleaningEquipmentWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_ElectronicWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_FoodDrinkWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "CleaningEquipmentWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "ElectronicWarehouseId",
                table: "Warehouses");

            migrationBuilder.RenameColumn(
                name: "FoodDrinkWarehouseId",
                table: "Warehouses",
                newName: "TypeWarehouseId");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeCode",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "TypeWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeWarehouseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeWarehouses_TypeWarehouses_TypeWarehouseId",
                        column: x => x.TypeWarehouseId,
                        principalTable: "TypeWarehouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_TypeWarehouseId",
                table: "Warehouses",
                column: "TypeWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeWarehouses_TypeWarehouseId",
                table: "TypeWarehouses",
                column: "TypeWarehouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_TypeWarehouses_TypeWarehouseId",
                table: "Warehouses",
                column: "TypeWarehouseId",
                principalTable: "TypeWarehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_TypeWarehouses_TypeWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropTable(
                name: "TypeWarehouses");

            migrationBuilder.DropIndex(
                name: "IX_Warehouses_TypeWarehouseId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "EmployeeCode",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "TypeWarehouseId",
                table: "Warehouses",
                newName: "FoodDrinkWarehouseId");

            migrationBuilder.AddColumn<int>(
                name: "CleaningEquipmentWarehouseId",
                table: "Warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElectronicWarehouseId",
                table: "Warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CleaningEquipmentWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleaningEquipmentWarehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElectronicWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectronicWarehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodDrinkWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDrinkWarehouses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_CleaningEquipmentWarehouseId",
                table: "Warehouses",
                column: "CleaningEquipmentWarehouseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_ElectronicWarehouseId",
                table: "Warehouses",
                column: "ElectronicWarehouseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_FoodDrinkWarehouseId",
                table: "Warehouses",
                column: "FoodDrinkWarehouseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_CleaningEquipmentWarehouses_CleaningEquipmentWarehouseId",
                table: "Warehouses",
                column: "CleaningEquipmentWarehouseId",
                principalTable: "CleaningEquipmentWarehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_ElectronicWarehouses_ElectronicWarehouseId",
                table: "Warehouses",
                column: "ElectronicWarehouseId",
                principalTable: "ElectronicWarehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_FoodDrinkWarehouses_FoodDrinkWarehouseId",
                table: "Warehouses",
                column: "FoodDrinkWarehouseId",
                principalTable: "FoodDrinkWarehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
