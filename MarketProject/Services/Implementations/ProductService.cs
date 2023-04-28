using AutoMapper;
using MarketProject.Datas.Entities;
using MarketProject.Dtos.ProductDtos;
using MarketProject.Repositories.Abstarctions;
using MarketProject.Services.Interfaces;

namespace MarketProject.Services.Implementations;
public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateProductDto createProductDto)
    {
        var document =_mapper.Map<Product>(createProductDto);
        await _productRepository.CreateAsync(document);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _productRepository.DeleteAsync(id);
        return true;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _productRepository.GetAllAsync();
    }

    public async Task<Product> UpdateAsync(int id, UpdateProductDto updateProductDto)
    {
        var result = await _productRepository.GetByIdAsync(id);
        if (result == null)
            return null;
        var product = _mapper.Map(updateProductDto,result);
        return product;
    }
}
