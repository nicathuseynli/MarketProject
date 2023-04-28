namespace MarketProject.Datas.Entities;
public class CleaningEquipmentWarehouse : BaseEntity<int>
{
    //navigation
    public virtual Warehouse? Warehouse { get; set; }
}
