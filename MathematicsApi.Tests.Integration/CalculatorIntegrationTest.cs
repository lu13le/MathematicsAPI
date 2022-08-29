using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsApi.Tests.Integration
{
    public class CalculatorIntegrationTest
    {
        [Fact]
        public async Task AddingTwoIntegers_ShouldReturnStatusCodeOK()
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7136/swagger/index.html")
            };

            var response = await httpClient.GetAsync($"/api/Calculator/Add?a=2&b=3");

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Fact]
        public async Task SubtractingTwoIntegers_ShouldReturnStatusCodeOK()
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7136/swagger/index.html")
            };

            var response = await httpClient.GetAsync($"/api/Calculator/Substract?a=5&b=3");

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

        [Fact]
        public async Task MultiplyingTwoIntegers_ShouldReturnStatusCodeOK()
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7136/swagger/index.html")
            };

            var response = await httpClient.GetAsync($"/api/Calculator/Multiply?a=2&b=9");

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }
        [Fact]
        public async Task DivideTwoIntegers_ShouldReturnStatusCodeOK()
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7136/swagger/index.html")
            };

            var response = await httpClient.GetAsync($"/api/Calculator/Divide?a=4&b=2");

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }

    }
}
