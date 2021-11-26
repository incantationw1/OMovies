using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OMovies.DTOs;
using OMovies.Helpers;
using OMovies.ViewModels;

namespace OMovies.Controllers
{
    public class MovieController : Controller
    {
        private readonly RequestHelper _requestHelper;

        public MovieController(RequestHelper requestHelper)
        {
            _requestHelper = requestHelper;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await _requestHelper.GetPopularMovies<MoviesViewModel>();

            for (var i = 2; i < viewModel.TotalPages; i++)
                viewModel.Movies.AddRange((await _requestHelper.GetPopularMovies<MoviesViewModel>(i)).Movies);

            viewModel.MoviesDateToString();
            viewModel.MoviesIsoToEnglishLanguages(await _requestHelper.GetLanguages<LanguagesDto>());

            viewModel.PageTitle = "Popular Movies";

            return View(viewModel);
        }

        public async Task<IActionResult> TopRated()
        {
            var viewModel = await _requestHelper.GetTopRatedMovies<MoviesViewModel>();

            for (var i = 2; i < viewModel.TotalPages; i++)
                viewModel.Movies.AddRange((await _requestHelper.GetTopRatedMovies<MoviesViewModel>(i)).Movies);

            viewModel.MoviesDateToString();
            viewModel.MoviesIsoToEnglishLanguages(await _requestHelper.GetLanguages<LanguagesDto>());

            viewModel.PageTitle = "Top Rated Movies";

            return View("Index", viewModel);
        }
    }
}
