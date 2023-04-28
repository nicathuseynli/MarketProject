using MarketProject.Datas.Entities;

namespace MarketProject.Repositories.Abstarctions;
public interface IProductRepository
{
    public Task CreateAsync(Product product);
    public Task UpdateAsync(Product product);
    public Task<Product> DeleteAsync(int id);
    public Task<List<Product>> GetAllAsync();
    public Task<Product> GetByIdAsync(int id);
}
