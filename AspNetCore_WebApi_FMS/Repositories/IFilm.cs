using System;
using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface IFilm
    {
        Film AddFilm (Film fm);
        void UpdateFilm (int filmId, Film fm);
        bool DeleteFilm (int filmId);
        IEnumerable<Film> SearchFilm (string title);
        Film SearchFilm (int releaseYear);
        Film SearchFilm (decimal rating);
        IEnumerable<Film> GetFilms();
    }
}
