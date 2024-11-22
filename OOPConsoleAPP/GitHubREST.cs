using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP
{

    //class declaration
    public class GitHubREST
    {

        //fields
        private readonly HttpClient _httpClient;


        //properties - Not required since we dont need to get or set

        //constructor

        public GitHubREST(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Methods - Method overloading

        public async Task<string> GetGitHubAPI(string baseUrl)
        {
            var response = await _httpClient.GetAsync(baseUrl);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }




    }
}
