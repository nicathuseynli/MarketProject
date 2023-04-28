using AutoMapper;
using MarketProject.Datas.Entities;
using MarketProject.Dtos.PartnerCompanyDtos;
using MarketProject.Repositories.Abstarctions;
using MarketProject.Services.Interfaces;

namespace MarketProject.Services.Implementations;
public class PartnerCompanyService : IPartnerCompanyService
{
    private readonly IPartnerCompanyRepository _partnercompanyRepository;
    private readonly IMapper _mapper;

    public PartnerCompanyService(IPartnerCompanyRepository partnercompanyRepository, IMapper mapper)
    {
        _partnercompanyRepository = partnercompanyRepository;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreatePartnerCompanyDto createPartnerCompanyDto)
    {
        var result = _mapper.Map<PartnerCompany>(createPartnerCompanyDto);
        await _partnercompanyRepository.CreateAsync(result);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _partnercompanyRepository.DeleteAsync(id);
        return true;
    }

    public async Task<List<PartnerCompany>> GetAllAsync()
    {
        return await _partnercompanyRepository.GetAllAsync();
    }

    public async Task<PartnerCompany> UpdateAsync(int id, UpdatePartnerCompanyDto updatePartnerCompanyDto)
    {
        var result = await _partnercompanyRepository.GetByIdAsync(id);
        if (result == null)
            return null;
        var partnerCompany = _mapper.Map(updatePartnerCompanyDto,result);
        return partnerCompany;
    }
}
