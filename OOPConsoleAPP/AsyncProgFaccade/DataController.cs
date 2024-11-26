using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP.AsyncProg
{
    public class DataController
    {
        private readonly DataService _dataService;

        public DataController()
        {
            _dataService = new DataService();
        }

        public async Task DisplayDataAsync()
        {
            var number = await _dataService.GetNumberAsync();
            Console.WriteLine($"Number: {number}");

            //var fileContent = await _dataService.ReadFileAsync("example.txt");
            //Console.WriteLine($"File Content: {fileContent}");

            //var apiData = await _dataService.FetchDataFromApiAsync("https://api.example.com");
            //Console.WriteLine($"API Data: {apiData}");
        }
    }
}
