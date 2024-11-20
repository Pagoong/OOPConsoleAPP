using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Moq.Protected;
using OOPConsoleAPP;

namespace PersonUnitTests3
{
    [TestClass]
    public class DataFetcherTests
    {
        [TestMethod]
        public async Task GetDataAsync_ShouldReturnResponseContent()
        {
            // Arrange
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("Mock response content")
                });

            var httpClient = new HttpClient(mockHttpMessageHandler.Object);
            var dataFetcher = new DataFletcher(httpClient);

            // Act
            var result = await dataFetcher.GetStringAsync("https://example.com");

            // Assert
            Assert.AreEqual("Mock response content", result);
        }
    }
}
