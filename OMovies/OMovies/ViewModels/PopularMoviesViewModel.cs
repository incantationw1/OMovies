using System.Collections.Generic;
using System.Text.Json.Serialization;
using OMovies.DTOs;
using OMovies.Interfaces;

namespace OMovies.ViewModels
{
    public class PopularMoviesViewModel : IMovies
    {
        [JsonPropertyName("results")]
        public List<MovieDto> Movies { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }
}
