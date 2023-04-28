namespace MarketProject.Datas.Entities;
public class FoodDrinkWarehouse : BaseEntity<int>
{
    //navigation
    public virtual Warehouse? Warehouse { get; set; }
}
