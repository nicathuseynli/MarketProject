using AutoMapper;
using MarketProject.Datas.Entities;
using MarketProject.Dtos.EmployeeDtos;
using MarketProject.Services.Interfaces;

namespace MarketProject.Services.Implementations;
public class MarketService : IMarketService
{
    private readonly IMarketService _marketServiceRepository;
    private readonly IMapper _mapper;

    public MarketService(IMarketService marketServiceRepository, IMapper mapper)
    {
        _marketServiceRepository = marketServiceRepository;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateEmployeeDto createEmployeeDto)
    {
        var creaateEmployeeDto = _mapper.Map<CreateEmployeeDto>(createEmployeeDto);
        await _marketServiceRepository.CreateAsync(creaateEmployeeDto);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _marketServiceRepository.DeleteAsync(id);
        return true;
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        return await _marketServiceRepository.GetAllAsync();
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        var employee = await _marketServiceRepository.GetByIdAsync(id);
        if (employee == null)
            return null;

        return employee;
    }

    public Task<Employee> UpdateAsync(int id, UpdateEmployeeDto updateEmployeeDto)
    {
        var result = _marketServiceRepository.GetByIdAsync(id);
        if (result == null)
            return null;
        var category = _mapper.Map(_marketServiceRepository, result);
        return category;
    }
}
