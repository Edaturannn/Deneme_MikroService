﻿using System;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
	public interface IProductImageService
	{
		Task<List<ResultProductImageDto>> GetAllProductImageAsync();
		Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
		Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
		Task DeleteProductImageAsync(string id);
		Task<List<GetByIdProductImageDto>> GetByIdProductImageAsync(string id);
    }
}