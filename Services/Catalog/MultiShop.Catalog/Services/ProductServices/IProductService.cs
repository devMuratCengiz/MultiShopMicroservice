﻿using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<List<ResultProductsWithCategoriesDto>> GetProductsWithCategoriesAsync();
        Task<List<ResultProductsWithCategoriesDto>> GetProductsWithCategoryByCategoryIdAsync(string categoryId);
    }
}
