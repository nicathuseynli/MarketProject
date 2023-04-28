using MarketProject.Datas.Entities;
using MarketProject.Dtos.ProductDtos;

namespace MarketProject.Services.Interfaces;
public interface IProductService
{
    public Task CreateAsync(CreateProductDto createProductDto);
    public Task<Product> UpdateAsync(int id,UpdateProductDto updateProductDto);
    public Task<bool> DeleteAsync(int id);
    public Task<List<Product>> GetAllAsync();
}
