using MarketProject.Datas.Entities;

namespace MarketProject.Repositories.Abstarctions;
public interface IMarketRepository
{
    Task CreateAsync(Employee employee);
    Task UpdateAsync(Employee employee);
    public Task<Employee> DeleteAsync(int id);
    public Task<List<Employee>> GetAllAsync();
    public Task<Employee> GetByIdAsync(int id);
    Task<int> GetEmployeeCodeIdAsync();
}
