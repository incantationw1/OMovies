using System.Text.Json.Serialization;

namespace OMovies.DTOs
{
    public class LanguagesDto
    {
        [JsonPropertyName("iso_639_1")]
        public string IsoName { get; set; }

        [JsonPropertyName("english_name")]
        public string Name { get; set; }
    }
}
