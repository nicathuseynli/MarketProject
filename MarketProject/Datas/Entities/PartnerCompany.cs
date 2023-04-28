namespace MarketProject.Datas.Entities;
public class PartnerCompany:BaseEntity<int>
{
    public string Name { get; set; }=string.Empty;
    public string ContractType { get; set; }
    public int ContractTime { get; set; }
    //navigation
    public int MarketId { get; set; }
    public virtual Market? Market { get; set; }
}
