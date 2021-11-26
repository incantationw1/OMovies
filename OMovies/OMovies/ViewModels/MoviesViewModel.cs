using System.Collections.Generic;
using System.Text.Json.Serialization;
using OMovies.DTOs;
using OMovies.Interfaces;

namespace OMovies.ViewModels
{
    public class MoviesViewModel : IMovies
    {
        public MoviesViewModel()
        {
            Movies = new List<MovieDto>();
        }

        [JsonPropertyName("results")]
        public List<MovieDto> Movies { get; set; }

        public string PageTitle { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }
    }
}