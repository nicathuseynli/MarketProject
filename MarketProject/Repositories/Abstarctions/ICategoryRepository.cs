using MarketProject.Datas.Entities;
using MarketProject.Dtos.CategoryDtos;

namespace MarketProject.Repositories.Abstarctions;
public interface ICategoryRepository
{
     Task CreateAsync(Category category);

     Task UpdateAsync(Category category);

     Task<Category> DeleteAsync(int id);

     Task<List<Category>> GetAllAsync();

     Task<Category> GetByIdAsync(int id);
}
