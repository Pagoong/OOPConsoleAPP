using System.Threading.Tasks;
using MealCategoryApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net;
using OOPConsoleAPP.HTTP;

namespace MealCategoryApp.Tests
{
    [TestClass]
    public class MealServiceTests
    {
        [TestMethod]
        public async Task GetMealCategoriesAsync_ReturnsCategories()
        {
            // Arrange
            var mockMealApiClient = new Mock<MealApiClient>(); // create a mock object 
            mockMealApiClient.Setup(client => client.GetCategoriesAsync()).ReturnsAsync("{\"categories\":[]}"); // used to return jason string 
            var mealService = new MealServiceWrapper(mockMealApiClient.Object);  //????

            // Act
            var result = await mealService.GetMealCategoriesAsync(); // return string data to result
            // Assert
            Assert.IsNotNull(result);  //checks if result is empty
            Assert.AreEqual("{\"categories\":[]}", result);  //check if the returned value are correct
        }


        
        [TestMethod]
        public async Task GetMealCategoriesAsync_ReturnsStatusCode200()
        {
            // Arrange
            var mockMealApiClient = new Mock<MealApiClient>();
            mockMealApiClient.Setup(client => client.GetCategoriesAsync()).ReturnsAsync((HttpStatusCode.OK, "{\"categories\":[]}"));
            var mealService = new MealServiceWrapper(mockMealApiClient.Object);

            // Act
            var (statusCode, result) = await mealService.GetMealCategoriesAsyncWithStatusCode();

            // Assert
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetMealCategoriesAsync_ReturnsStatusCode400()
        {
            // Arrange
            var mockMealApiClient = new Mock<MealApiClient>();
            mockMealApiClient.Setup(client => client.GetCategoriesAsync()).ReturnsAsync((HttpStatusCode.BadRequest, null));
            var mealService = new MealServiceWrapper(mockMealApiClient.Object);

            // Act
            var (statusCode, result) = await mealService.GetMealCategoriesAsyncWithStatusCode();

            // Assert
            Assert.AreEqual(HttpStatusCode.BadRequest, statusCode);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task GetMealCategoriesAsync_ReturnsStatusCode401()
        {
            // Arrange
            var mockMealApiClient = new Mock<MealApiClient>();
            mockMealApiClient.Setup(client => client.GetCategoriesAsync()).ReturnsAsync((HttpStatusCode.Unauthorized, null));
            var mealService = new MealServiceWrapper(mockMealApiClient.Object);

            // Act
            var (statusCode, result) = await mealService.GetMealCategoriesAsyncWithStatusCode();

            // Assert
            Assert.AreEqual(HttpStatusCode.Unauthorized, statusCode);
            Assert.IsNull(result);
        }

        [TestMethod]
        public async Task GetMealCategoriesAsync_ReturnsStatusCode403()
        {
            // Arrange
            var mockMealApiClient = new Mock<MealApiClient>();
            mockMealApiClient.Setup(client => client.GetCategoriesAsync()).ReturnsAsync((HttpStatusCode.Forbidden, null));
            var mealService = new MealServiceWrapper(mockMealApiClient.Object);

            // Act
            var (statusCode, result) = await mealService.GetMealCategoriesAsyncWithStatusCode();

            // Assert
            Assert.AreEqual(HttpStatusCode.Forbidden, statusCode);
            Assert.IsNull(result);
        }
    }

    // Wrapper class to allow injection of mocked dependencies
    public class MealServiceWrapper : MealService
    {
        public MealServiceWrapper(MealApiClient mealApiClient)
        {
            _mealApiClient = mealApiClient;
        }

        public async Task<(HttpStatusCode, string)> GetMealCategoriesAsyncWithStatusCode()
        {
            // Uses the API client to fetch meal categories with status code
            return await _mealApiClient.GetCategoriesAsyncWithStatusCode();
        }
    }
}
