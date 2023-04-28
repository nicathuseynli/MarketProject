namespace MarketProject.Datas.Entities;
public class Market : BaseEntity<int>
{
    public string Name { get; set; }
    //navigation
    public virtual ICollection<Warehouse>? Warehouses{ get; set; }
    //navigation
    public virtual ICollection<PartnerCompany>? PartnerCompanies { get; set; }
    //navigation
    public virtual ICollection<Employee> Employees { get; set; }
}
