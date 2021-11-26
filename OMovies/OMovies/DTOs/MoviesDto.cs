using System.Collections.Generic;
using System.Text.Json.Serialization;
using OMovies.Interfaces;

namespace OMovies.DTOs
{
    public class MoviesDto : IMovies
    {
        [JsonPropertyName("results")]
        public List<MovieDto> Movies { get; set; }
    }
}