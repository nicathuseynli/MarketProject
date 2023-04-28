namespace MarketProject.Datas.Entities;
public class Category:BaseEntity<int>
{
    public string Type { get; set; }
    public virtual ICollection<Warehouse> Warehouses { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}
