using AutoMapper;
using MarketProject.Datas.Entities;
using MarketProject.Dtos.CategoryDtos;
using MarketProject.Repositories.Abstarctions;
using MarketProject.Services.Interfaces;

namespace MarketProject.Services.Implementations;
public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateCategoryDto categoryCreateDto)
    {
        var createCategory = _mapper.Map<Category>(categoryCreateDto);
        await _categoryRepository.CreateAsync(createCategory);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _categoryRepository.DeleteAsync(id);
        return true;
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await _categoryRepository.GetAllAsync();
    }

    public Task<Category> UpdateAsync(int id, UpdateCategoryDto updateCategoryDto)
    {
        var result = _categoryRepository.GetByIdAsync(id);
        if (result == null)
            return null;
        var category = _mapper.Map(updateCategoryDto, result);
        return category;
    }
}
