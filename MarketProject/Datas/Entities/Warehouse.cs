namespace MarketProject.Datas.Entities;
public class Warehouse:BaseEntity<int>
{
    //navigationMarket
    public int MarketId { get; set; }
    public virtual Market? Market { get; set; }
    //navigationCategory
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
    //navigationTypeWarehouse
    public int TypeWarehouseId { get; set; }
    public virtual TypeWarehouse? TypeWarehouse { get; set; }
}
