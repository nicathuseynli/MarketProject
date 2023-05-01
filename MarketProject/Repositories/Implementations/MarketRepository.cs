using MarketProject.Datas.Context;
using MarketProject.Datas.Entities;
using MarketProject.Repositories.Abstarctions;
using Microsoft.EntityFrameworkCore;

namespace MarketProject.Repositories.Implementations;
public class MarketRepository : IMarketRepository
{
    private readonly MarketDbContext _marketDbContext;

    public MarketRepository(MarketDbContext marketDbContext)
    {
        _marketDbContext = marketDbContext;
    }

    public async Task CreateAsync(Employee employee)
    {
        await _marketDbContext.Employees.AddAsync(employee);
        await _marketDbContext.SaveChangesAsync();
    }

    public async Task<Employee> DeleteAsync(int id)
    {
        var result = await _marketDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
            return null;
        _marketDbContext.Employees.Remove(result);
        await _marketDbContext.SaveChangesAsync();
        return result;
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        return await _marketDbContext.Employees.ToListAsync();
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        var result = await _marketDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
            return null;
        return result;
    }

    public async Task<int> GetEmployeeCodeIdAsync()
    {
        Employee employee = await _marketDbContext.Employees.OrderByDescending(m => m.Id).FirstOrDefaultAsync();

        if (employee == null)
        {
            return 0;
        }

        return employee.Id;
    }

    public async Task UpdateAsync(Employee employee)
    {
        _marketDbContext.Employees.Update(employee);
        await _marketDbContext.SaveChangesAsync();
    }
}
