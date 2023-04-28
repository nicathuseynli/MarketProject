using MarketProject.Datas.Context;
using MarketProject.Datas.Entities;
using MarketProject.Repositories.Abstarctions;
using Microsoft.EntityFrameworkCore;

namespace MarketProject.Repositories.Implementations;
public class CategoryRepository : ICategoryRepository
{
    private readonly MarketDbContext _marketDbContext;

    public CategoryRepository(MarketDbContext marketDbContext)
    {
        _marketDbContext = marketDbContext;
    }

    public async Task CreateAsync(Category category)
    {
        await _marketDbContext.Categories.AddAsync(category);
        await _marketDbContext.SaveChangesAsync();
    }

    public async Task<Category> DeleteAsync(int id)
    {
        var result = await _marketDbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
            return null;
        _marketDbContext.Categories.Remove(result);
        _marketDbContext.SaveChangesAsync();
        return result;
    }

    public async Task<List<Category>> GetAllAsync()
    {
       return await _marketDbContext.Categories.
            Include(p =>p.Warehouses).ThenInclude(p=>p.FoodDrinkWarehouse).
            Include(p=>p.Warehouses).ThenInclude(p=>p.ElectronicWarehouse).
            Include(p=>p.Warehouses).ThenInclude(p=>p.CleaningEquipmentWarehouse).ToListAsync();
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        var result = await _marketDbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
            return null;
        return result;
    }

    public async Task UpdateAsync(Category category)
    {
        _marketDbContext.Categories.Update(category);
        await _marketDbContext.SaveChangesAsync();
    }
}
