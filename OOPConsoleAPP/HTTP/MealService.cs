using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleAPP.HTTP
{
    // MealService: Contains the business logic to interact with the API
    public class MealService
    {
        private readonly MealApiClient _mealApiClient;

        public MealService()
        {
            _mealApiClient = new MealApiClient();
        }

        public async Task<string> GetMealCategoriesAsync()
        {
            // Uses the API client to fetch meal categories
            return await _mealApiClient.GetCategoriesAsync();
        }
    }
}
