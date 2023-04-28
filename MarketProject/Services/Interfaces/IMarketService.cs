using MarketProject.Datas.Entities;
using MarketProject.Dtos.EmployeeDtos;

namespace MarketProject.Services.Interfaces;
public interface IMarketService
{
    Task CreateAsync(CreateEmployeeDto createEmployeeDto);

    Task<Employee> UpdateAsync(int id, UpdateEmployeeDto updateEmployeeDto);

    Task<bool> DeleteAsync(int id);

    Task<Employee> GetByIdAsync(int id);

    Task<List<Employee>> GetAllAsync();
}
