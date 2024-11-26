using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP.AsyncProg
{
    public class DataService
    {
        public async Task<int> GetNumberAsync()
        {
            await Task.Delay(2000); // Simulates a delay, such as a network call
            return 42;
        }

        //public async Task<string> ReadFileAsync(string filePath)
        //{
        //    using (StreamReader reader = new StreamReader(filePath))
        //    {
        //        return await reader.ReadToEndAsync();
        //    }
        //}

        //public async Task<string> FetchDataFromApiAsync(string url)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        return await client.GetStringAsync(url);
        //    }
        //}
    }
}
