using MarketProject.Datas.Entities;

namespace MarketProject.Repositories.Abstarctions;
public interface IPartnerCompanyRepository
{
    public Task CreateAsync(PartnerCompany partnerCompany);
    public Task UpdateAsync(PartnerCompany partnerCompany);
    public Task<PartnerCompany> DeleteAsync(int id);
    public Task<List<PartnerCompany>> GetAllAsync();
    public Task<PartnerCompany> GetByIdAsync(int id);
}
