using MarketProject.Datas.Entities;
using MarketProject.Dtos.PartnerCompanyDtos;
using MarketProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerCompanyController : ControllerBase
    {
        private readonly IPartnerCompanyService _partnercompanyService;

        public PartnerCompanyController(IPartnerCompanyService partnercompanyService)
        {
            _partnercompanyService = partnercompanyService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePartnerCompanyDto createPartnerCompanyDto)
        {
            await _partnercompanyService.CreateAsync(createPartnerCompanyDto);
            return Ok($"{createPartnerCompanyDto.Name} + {createPartnerCompanyDto.ContractType}  Succesfully Created");
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, UpdatePartnerCompanyDto updatePartnerCompanyDto)
        {
            var result = await _partnercompanyService.UpdateAsync(id, updatePartnerCompanyDto);
            if (result == null)
                return BadRequest($"{updatePartnerCompanyDto.Name} Can Not Updated");
            return Ok($"{updatePartnerCompanyDto.Name} and {updatePartnerCompanyDto.ContractType} Succesfully Updated");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _partnercompanyService.DeleteAsync(Id);
            if (result == null)
                return NotFound();
            return Ok();
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _partnercompanyService.GetAllAsync();
            if (result == null)
                return NotFound("Products Not Found");
            return Ok(result);
        }

    }
}
