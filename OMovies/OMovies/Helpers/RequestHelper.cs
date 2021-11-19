using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OMovies.Helpers
{
    public class RequestHelper
    {
        private readonly IConfiguration _configuration;

        public RequestHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<T> GetPopularMovies<T>(int? page = null)
        {
            using var client = new HttpClient();

            var uri = _configuration.GetValue<string>("PopularMoviesUri");
            var apiKey = _configuration.GetValue<string>("MoviesDbKey");

            var response = await (await client.GetAsync($"{uri}{apiKey}{(page != null ? $"&page={page}" : "")}"))
                .Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(response);
        }
    }
}