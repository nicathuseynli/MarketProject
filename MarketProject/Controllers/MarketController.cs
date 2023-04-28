using MarketProject.Dtos.EmployeeDtos;
using MarketProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly IMarketService _marketService;

        public MarketController(IMarketService marketService)
        {
            _marketService = marketService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeDto createEmployeeDto)
        {
            await _marketService.CreateAsync(createEmployeeDto);
            return Ok($"{createEmployeeDto.Name} Successfully Joined");
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id,UpdateEmployeeDto updateEmployeeDto)
        {
            var result = await _marketService.UpdateAsync(id, updateEmployeeDto);
            if (result == null)
                return BadRequest("Can Not Updated");
            return Ok("Succesfully Updated");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _marketService.DeleteAsync(Id);
            if (result == null)
                return NotFound();
            return Ok();
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _marketService.GetAllAsync();
            if (result == null)
                return NotFound("Employees Not Found");
            return Ok(result);
        }
    }
}
