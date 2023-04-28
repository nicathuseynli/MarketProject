namespace MarketProject.Datas.Entities;
public class Product:BaseEntity<int>
{
    public string Name { get; set; }=string.Empty;
    public decimal Price { get; set; }
    public string Brend { get; set; }=string.Empty ;
    public int CategoryId { get; set; }
    //navigation
    public virtual Category? Category { get; set; }
}
