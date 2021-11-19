using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            var viewModel = await _requestHelper.GetPopularMovies<PopularMoviesViewModel>();

            viewModel.MoviesDateToString();

            return View(viewModel);
        }

        public IActionResult TopRated()
        {
            return View();
        }
    }
}
