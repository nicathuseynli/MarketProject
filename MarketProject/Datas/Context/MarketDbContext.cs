using MarketProject.Datas.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MarketProject.Datas.Context;
public class MarketDbContext : IdentityDbContext<AppUser>
{
    public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options)
    {

    }
    public DbSet<Market> Markets { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<PartnerCompany> PartnerCompanies { get; set; }
    public DbSet<ElectronicWarehouse> ElectronicWarehouses { get; set; }
    public DbSet<FoodDrinkWarehouse> FoodDrinkWarehouses { get; set; }
    public DbSet<CleaningEquipmentWarehouse> CleaningEquipmentWarehouses { get; set; }
}
