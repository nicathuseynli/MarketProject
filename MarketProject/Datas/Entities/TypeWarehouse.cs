namespace MarketProject.Datas.Entities;
public class TypeWarehouse:BaseEntity<int>
{
    public virtual ICollection<TypeWarehouse> TypeWarehouses { get; set; }
}
