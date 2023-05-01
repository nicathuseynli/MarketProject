namespace MarketProject.Datas.Entities;
public class Market : BaseEntity<int>
{
    public string Name { get; set; }
    //bu kompaniya verdiyi pasword ve user
    //string password = "Araz12345";
    //string username = "Araz@gmial.com";


    //string username = "Araz@gmial.com";
    //string password = "xdmfdbfkhesio4u";

    //navigation
    public virtual ICollection<Warehouse>? Warehouses{ get; set; }
    //navigation
    public virtual ICollection<PartnerCompany>? PartnerCompanies { get; set; }
    //navigation
    public virtual ICollection<Employee> Employees { get; set; }
}
