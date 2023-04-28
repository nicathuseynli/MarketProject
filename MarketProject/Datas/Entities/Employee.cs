namespace MarketProject.Datas.Entities;
public class Employee:BaseEntity<int>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Profession { get; set; }
    public decimal Salary { get; set; }
    public string EmployeeCode { get; set; }
    public bool IsDeleted { get; set; }
    //navigation
    public virtual Market? Market { get; set; }
    public int MarketId { get; set; }
}
