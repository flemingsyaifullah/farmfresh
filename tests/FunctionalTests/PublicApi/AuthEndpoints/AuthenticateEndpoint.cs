﻿using FarmFresh.ApplicationCore.Constants;
using FarmFresh.FunctionalTests.PublicApi;
using FarmFresh.PublicApi.AuthEndpoints;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace FarmFresh.FunctionalTests.Web.Controllers
{
    [Collection("Sequential")]
    public class AuthenticateEndpoint : IClassFixture<ApiTestFixture>
    {
        JsonSerializerOptions _jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public AuthenticateEndpoint(ApiTestFixture factory)
        {
            Client = factory.CreateClient();
        }

        public HttpClient Client { get; }

        [Theory]
        [InlineData("farmfreshuser1@farmfresh.com", AuthorizationConstants.DEFAULT_PASSWORD, true)]
        [InlineData("farmfreshuser1@farmfresh.com", "badpassword", false)]
        [InlineData("baduser@farmfresh.com", "badpassword", false)]
        public async Task ReturnsExpectedResultGivenCredentials(string testUsername, string testPassword, bool expectedResult)
        {
            var request = new AuthenticateRequest() 
            { 
                Username = testUsername,
                Password = testPassword
            };
            var jsonContent = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
            var response = await Client.PostAsync("api/authenticate", jsonContent);
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            var model = stringResponse.FromJson<AuthenticateResponse>();

            Assert.Equal(expectedResult, model.Result);
        }        
    }
}
