﻿using MultiShop.Dto.CatalogDtos.AboutDtos;
using Newtonsoft.Json;

namespace MultiShop.WebUI.Services.CatalogServices.AboutServices
{
    public class AboutService:IAboutService
    {
        private readonly HttpClient _httpClient;

        public AboutService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreateAboutAsync(CreateAboutDto createAboutDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateAboutDto>("abouts", createAboutDto);

        }

        public async Task DeleteAboutAsync(string id)
        {
            await _httpClient.DeleteAsync("abouts/" + id);
        }

        public async Task<List<ResultAboutDto>> GetAllAboutsAsync()
        {
            var responseMessage = await _httpClient.GetAsync("abouts");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
            return values;
        }

        public async Task<UpdateAboutDto> GetByIdAboutAsync(string id)
        {
            var responseMessage = await _httpClient.GetAsync("abouts/" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<UpdateAboutDto>();
            return values;
        }

        public async Task UpdateAboutAsync(UpdateAboutDto updateAboutDto)
        {
            await _httpClient.PutAsJsonAsync<UpdateAboutDto>("abouts", updateAboutDto);
        }
    }
    
}