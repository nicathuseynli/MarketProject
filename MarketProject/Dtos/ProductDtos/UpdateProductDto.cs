﻿namespace MarketProject.Dtos.ProductDtos;
public class UpdateProductDto
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Brend { get; set; } = string.Empty;
    public int CategoryId { get; set; }
    
}
