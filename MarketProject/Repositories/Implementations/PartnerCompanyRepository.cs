using MarketProject.Datas.Context;
using MarketProject.Datas.Entities;
using MarketProject.Repositories.Abstarctions;
using Microsoft.EntityFrameworkCore;

namespace MarketProject.Repositories.Implementations;
public class PartnerCompanyRepository : IPartnerCompanyRepository
{
    private readonly MarketDbContext _marketDbContext;

    public PartnerCompanyRepository(MarketDbContext marketDbContext)
    {
        _marketDbContext = marketDbContext;
    }
    public async Task CreateAsync(PartnerCompany partnerCompany)
    {
        await _marketDbContext.PartnerCompanies.AddAsync(partnerCompany);
        await _marketDbContext.SaveChangesAsync();
    }

    public async Task<PartnerCompany> DeleteAsync(int id)
    {
        var result = await _marketDbContext.PartnerCompanies.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
            return null;
        _marketDbContext.PartnerCompanies.Remove(result);
        await _marketDbContext.SaveChangesAsync();
        return result;
    }

    public async Task<List<PartnerCompany>> GetAllAsync()
    {
        return await _marketDbContext.PartnerCompanies.ToListAsync();
    }

    public async Task<PartnerCompany> GetByIdAsync(int id)
    {
        var result = await _marketDbContext.PartnerCompanies.FirstOrDefaultAsync(x => x.Id == id);
        if (result == null)
            return null;
        return result;
    }

    public async Task UpdateAsync(PartnerCompany partnerCompany)
    {
        _marketDbContext.PartnerCompanies.Update(partnerCompany);
        await _marketDbContext.SaveChangesAsync();
    }
}
