using System;
using System.Text.Json.Serialization;

namespace OMovies.DTOs
{
    public class MovieDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; }

        [JsonPropertyName("release_date")]
        public DateTime ReleaseDate { get; set; }

        public string ReleaseDateString { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
        
        [JsonPropertyName("vote_average")]
        public decimal VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }
}