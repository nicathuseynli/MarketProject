using MarketProject.Datas.Entities;
using MarketProject.Dtos.CategoryDtos;

namespace MarketProject.Services.Interfaces;
public interface ICategoryService
{
    Task CreateAsync(CreateCategoryDto categoryCreateDto); 

    Task<Category> UpdateAsync(int id, UpdateCategoryDto updateCategoryDto);

    Task<bool> DeleteAsync(int id);

    Task<List<Category>> GetAllAsync();
}
