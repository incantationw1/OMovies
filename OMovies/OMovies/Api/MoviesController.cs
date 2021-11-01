using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using OMovies.DTOs;

namespace OMovies.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public async Task<IActionResult> GetMovies(int? page = null)
        {
            List<MovieDto> dtos;

            using (var client = new HttpClient())
            {
                try
                {
                    var uri =
                        $"https://api.themoviedb.org/3/movie/popular?api_key=dad8a59d86a2793dda93aa485f7339c1{(page != null ? $"&page={page}" : "")}";
                    var response = await (await client.GetAsync(uri)).Content.ReadAsStringAsync();

                    dtos = JsonSerializer.Deserialize<List<MovieDto>>(response);
                }
                catch (Exception)
                {
                    return BadRequest("An unexpected error has occurred.");
                }
            }

            return Ok(dtos);
        }
    }
}
