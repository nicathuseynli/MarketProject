using MarketProject.Dtos.ProductDtos;
using MarketProject.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto createProductDto)
        {
            await _productService.CreateAsync(createProductDto);
            return Ok($"{createProductDto.Name} + {createProductDto.Brend}  Succesfully Created");
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id,UpdateProductDto updateProductDto)
        {
            var result = await _productService.UpdateAsync(id, updateProductDto);
            if (result == null)
                return BadRequest($"{updateProductDto.Name} Can Not Updated");
            return Ok($"{updateProductDto.Name} Succesfully Updated");
        }
        [HttpDelete]
        public async Task<IActionResult>Delete(int Id)
        {
            var result = await _productService.DeleteAsync(Id);
            if (result == null)
                return NotFound();
            return Ok();
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
            if (result == null)
                return NotFound("Products Not Found");
            return Ok(result);
        }
    }
}
