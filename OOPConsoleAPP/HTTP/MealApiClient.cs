using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP.HTTP
{
    // MealApiClient: Responsible for making HTTP requests
    public class MealApiClient
    {
        private readonly HttpClient _httpClient;
        private const string CategoriesUrl = "https://www.themealdb.com/api/json/v1/1/categories.php";

        public MealApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetCategoriesAsync()
        {
            try
            {
                // Make the HTTP GET request
                HttpResponseMessage response = await _httpClient.GetAsync(CategoriesUrl);
                response.EnsureSuccessStatusCode();

                // Read and return the response content as a string
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                // Handle any errors that occur during the HTTP request
                Console.WriteLine($"Request error: {ex.Message}");
                return null;
            }
        }
    }
}
