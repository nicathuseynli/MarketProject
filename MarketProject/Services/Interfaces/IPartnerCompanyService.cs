using MarketProject.Datas.Entities;
using MarketProject.Dtos.PartnerCompanyDtos;

namespace MarketProject.Services.Interfaces;
public interface IPartnerCompanyService
{
    public Task CreateAsync(CreatePartnerCompanyDto createPartnerCompanyDto);
    public Task<PartnerCompany> UpdateAsync(int id, UpdatePartnerCompanyDto updatePartnerCompanyDto);
    public Task<bool> DeleteAsync(int id);
    public Task<List<PartnerCompany>> GetAllAsync();
}
