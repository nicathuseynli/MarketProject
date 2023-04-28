namespace MarketProject.Datas.Entities;
public class ElectronicWarehouse:BaseEntity<int>
{
    //navigation
    public virtual Warehouse? Warehouse { get; set; }
}
