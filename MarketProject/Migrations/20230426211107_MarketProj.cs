using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketProject.Migrations
{
    public partial class MarketProj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brend = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartnerCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractTime = table.Column<int>(type: "int", nullable: false),
                    MarketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PartnerCompanies_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarketId = table.Column<int>(type: "int", nullable: false),
                    ElectronicWarehouseId = table.Column<int>(type: "int", nullable: false),
                    FoodDrinkWarehouseId = table.Column<int>(type: "int", nullable: false),
                    CleaningEquipmentWarehouseId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Warehouses_CleaningEquipmentWarehouses_CleaningEquipmentWarehouseId",
                        column: x => x.CleaningEquipmentWarehouseId,
                        principalTable: "CleaningEquipmentWarehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Warehouses_ElectronicWarehouses_ElectronicWarehouseId",
                        column: x => x.ElectronicWarehouseId,
                        principalTable: "ElectronicWarehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Warehouses_FoodDrinkWarehouses_FoodDrinkWarehouseId",
                        column: x => x.FoodDrinkWarehouseId,
                        principalTable: "FoodDrinkWarehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Warehouses_Markets_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Markets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartnerCompanies_MarketId",
                table: "PartnerCompanies",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_CategoryId",
                table: "Warehouses",
                column: "CategoryId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_MarketId",
                table: "Warehouses",
                column: "MarketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartnerCompanies");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CleaningEquipmentWarehouses");

            migrationBuilder.DropTable(
                name: "ElectronicWarehouses");

            migrationBuilder.DropTable(
                name: "FoodDrinkWarehouses");

            migrationBuilder.DropTable(
                name: "Markets");
        }
    }
}
