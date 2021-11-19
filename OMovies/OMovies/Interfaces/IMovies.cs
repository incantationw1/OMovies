using System.Collections.Generic;
using OMovies.DTOs;

namespace OMovies.Interfaces
{
    public interface IMovies
    {
        public List<MovieDto> Movies { get; set; }
    }
}
