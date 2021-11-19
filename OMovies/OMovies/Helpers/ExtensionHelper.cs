using System.Globalization;
using System.Threading;
using OMovies.Interfaces;

namespace OMovies.Helpers
{
    public static class ExtensionHelper
    {
        public static void MoviesDateToString(this IMovies dto)
        {
            if (dto?.Movies != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                foreach (var movie in dto.Movies)
                    movie.ReleaseDateString = movie.ReleaseDate.ToShortDateString();
            }
        }
    }
}