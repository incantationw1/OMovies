using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using OMovies.DTOs;
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
                    movie.ReleaseDateString = DateTime.TryParse(movie.ReleaseDateString, out var resultDateTime)
                        ? resultDateTime.ToShortDateString()
                        : "";
            }
        }

        public static void MoviesIsoToEnglishLanguages(this IMovies dto, List<LanguagesDto> languagesDto)
        {
            if (dto?.Movies != null)
            {
                var languages = new Dictionary<string, string>();

                foreach (var language in languagesDto)
                    languages.Add(language.IsoName, language.Name);

                foreach (var movie in dto.Movies)
                {
                    try
                    {
                        movie.OriginalLanguage = languages[movie.OriginalLanguage];
                    }
                    catch (Exception)
                    {
                        movie.OriginalLanguage = "";
                    }
                }
            }
        }
    }
}