using MarketProject.Dtos.CategoryDtos;
using MarketProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateAsync(createCategoryDto);
            return Ok("Succesfully Created");
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, UpdateCategoryDto updateCategoryDto)
        {
            var result = await _categoryService.UpdateAsync(id, updateCategoryDto);
            if (result == null)
                return BadRequest("Can Not Updated");
            return Ok("Succesfully Updated");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _categoryService.DeleteAsync(Id);
            if (result == null)
                return NotFound();
            return Ok();
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAllAsync();
            if (result == null)
                return NotFound("Products Not Found");
            return Ok(result);
        }
    }
}
