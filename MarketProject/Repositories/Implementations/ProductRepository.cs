using MarketProject.Datas.Context;
using MarketProject.Datas.Entities;
using MarketProject.Repositories.Abstarctions;
using Microsoft.EntityFrameworkCore;

namespace MarketProject.Repositories.Implementations;
public class ProductRepository : IProductRepository
{
    private readonly MarketDbContext _marketDbContext;

    public ProductRepository(MarketDbContext marketDbContext)
    {
        _marketDbContext = marketDbContext;
    }

    public async Task CreateAsync(Product product)
    {
        await _marketDbContext.Products.AddAsync(product);
        await _marketDbContext.SaveChangesAsync();
    }

    public async Task<Product> DeleteAsync(int id)
    {
       var result = await _marketDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
            return null;
         _marketDbContext.Products.Remove(result);
        await _marketDbContext.SaveChangesAsync();
        return result;
        
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _marketDbContext.Products
            .ToListAsync();
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        var result = await _marketDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
            return null;
        return result;
    }

    public async Task UpdateAsync(Product product)
    {
        _marketDbContext.Products.Update(product);
        await _marketDbContext.SaveChangesAsync();
    }
}
