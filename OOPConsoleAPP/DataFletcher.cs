using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP
{
    public class DataFletcher
    {

        private readonly HttpClient _httpClient;
        
        //Constructor
        public  DataFletcher(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //method overloading
        public async Task<string> GetStringAsync(string baseUrl)
        {
            var response = await _httpClient.GetAsync(baseUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetStringAsync(string baseUrl, string repositoryName)
        {
            string formattedUrl = $"{baseUrl}/repository/{repositoryName}";
            var response = await _httpClient.GetAsync(formattedUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetStringAsync(string baseUrl, string repositoryName, int id)
        {
            string formattedUrl = $"{baseUrl}/repository/{repositoryName}/item/{id}";
            var response = await _httpClient.GetAsync(formattedUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }



    }
}
