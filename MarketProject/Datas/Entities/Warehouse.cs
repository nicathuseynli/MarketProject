namespace MarketProject.Datas.Entities;
public class Warehouse:BaseEntity<int>
{
    //navigationMarket
    public int MarketId { get; set; }
    public virtual Market? Market { get; set; }
    //navigationWarehouses
    public int ElectronicWarehouseId { get; set; }
    public virtual ElectronicWarehouse? ElectronicWarehouse { get; set; }
    public int FoodDrinkWarehouseId { get; set; }
    public virtual FoodDrinkWarehouse? FoodDrinkWarehouse { get; set; }
    public int CleaningEquipmentWarehouseId { get; set; }
    public virtual CleaningEquipmentWarehouse? CleaningEquipmentWarehouse { get; set; }
    //navigationCategory
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}
