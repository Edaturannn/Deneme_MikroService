using System;
using MultiShop.Catalog.Dtos.CategoryDtos;

namespace MultiShop.Catalog.Services.CategoryServices
{
	public interface ICategoryService //İmzalaraı attık.
	{
		Task<List<ResultCategoryDto>> GetAllCategoryAsync();
		Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
		Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
		Task DeleteCategoryAsync(string id);
		Task<List<GetByIdCategoryDto>> GetByIdCategoryAsync(string id);
    }
}

