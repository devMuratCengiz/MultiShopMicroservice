﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.Dto.CatalogDtos.ProductDtos;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;
using Newtonsoft.Json;

namespace MultiShop.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultProduct:ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProduct(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductsAsync();
            return View(values);
        }
    }
}
