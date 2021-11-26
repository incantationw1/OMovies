using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace OMovies.Helpers
{
    public class RequestHelper
    {
        private readonly string _popularMovieUri;
        private readonly string _apiKey;
        private readonly string _topRatedMovieUri;
        private readonly string _moviesLanguagesUri;
        private readonly string _movieDetailsUri;
        private readonly string _moviePosterUri;

        public RequestHelper(IConfiguration configuration)
        {
            _popularMovieUri = configuration.GetValue<string>("PopularMoviesUri");
            _topRatedMovieUri = configuration.GetValue<string>("PopularMoviesUri");
            _moviesLanguagesUri = configuration.GetValue<string>("MoviesLanguagesUri");
            _movieDetailsUri = configuration.GetValue<string>("MovieDetailsUri");
            _moviePosterUri = configuration.GetValue<string>("MoviePosterUri");
            _apiKey = configuration.GetValue<string>("MoviesDbKey");
        }

        public async Task<T> GetPopularMovies<T>(int? page = null)
        {
            return await GetMovies<T>(_popularMovieUri, page);
        }

        public async Task<T> GetTopRatedMovies<T>(int? page = null)
        {
            return await GetMovies<T>(_topRatedMovieUri, page);
        }

        private async Task<T> GetMovies<T>(string uri, int? page = null)
        {
            try
            {
                using var client = new HttpClient();

                var response = await (await client.GetAsync($"{uri}{_apiKey}{(page != null ? $"&page={page}" : "")}"))
                    .Content.ReadAsStringAsync();
                response = response.Replace(@" """"", "null");

                return JsonSerializer.Deserialize<T>(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<T>> GetLanguages<T>()
        {
            try
            {
                using var client = new HttpClient();

                var response = await (await client.GetAsync($"{_moviesLanguagesUri}{_apiKey}"))
                    .Content.ReadAsStringAsync();
                response = response.Replace(@" """"", "null");

                return JsonSerializer.Deserialize<List<T>>(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<T> GetMovie<T>(int id)
        {
            try
            {
                using var client = new HttpClient();

                var response = await (await client.GetAsync($"{_movieDetailsUri}{id}?api_key={_apiKey}"))
                    .Content.ReadAsStringAsync();
                response = response.Replace(@" """"", "null");

                return JsonSerializer.Deserialize<T>(response);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string GetPosterUri()
        {
            return _moviePosterUri;
        }
    }
}