using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using OMovies.DTOs;
using OMovies.Helpers;

namespace OMovies.Api
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly RequestHelper _requestHelper;

        public MoviesController(RequestHelper requestHelper)
        {
            _requestHelper = requestHelper;
        }
        public async Task<IActionResult> GetMovies(int? page = null)
        {
            MoviesDto dto;

            try
            {
                dto = await _requestHelper.GetPopularMovies<MoviesDto>(page);

                dto.MoviesDateToString();
            }
            catch (Exception)
            {
                return BadRequest("An unexpected error has occurred.");
            }

            return Ok(dto);
        }

        public async Task<IActionResult> GetMovie(int id)
        {
            return Ok();
        }
    }
}
