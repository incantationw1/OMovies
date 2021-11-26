using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMovies.Data;
using OMovies.DTOs;
using OMovies.Helpers;
using OMovies.Models;

namespace OMovies.Api
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly RequestHelper _requestHelper;
        private readonly ApplicationDbContext _dbContext;

        public MoviesController(RequestHelper requestHelper, ApplicationDbContext dbContext)
        {
            _requestHelper = requestHelper;
            _dbContext = dbContext;
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
            var dto = await _requestHelper.GetMovie<MovieDto>(id);
            dto.PosterPath = $"{_requestHelper.GetPosterUri()}{dto.PosterPath}";
            var userName = User.Identity?.Name;
            var favoriteMovie = await _dbContext.FavoriteMovies.FirstOrDefaultAsync(f => f.MovieId == id && f.UserName == userName);

            if (favoriteMovie != null)
                dto.IsFavorite = true;

            return Ok(dto);
        }

        public async Task<IActionResult> AddFavorite(int id)
        {
            var favoriteMovie = new FavoriteMovie
            {
                MovieId = id,
                UserName = User.Identity?.Name
            };

            await _dbContext.FavoriteMovies.AddAsync(favoriteMovie);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        public async Task<IActionResult> RemoveFavorite(int id)
        {
            var userName = User.Identity?.Name;
            var favoriteMovie = await _dbContext.FavoriteMovies.FirstOrDefaultAsync(f => f.MovieId == id && f.UserName == userName);

            if (favoriteMovie != null)
            {
                _dbContext.FavoriteMovies.Remove(favoriteMovie);
                await _dbContext.SaveChangesAsync();
            }

            return Ok();
        }
    }
}
