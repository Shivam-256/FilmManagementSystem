using System;
using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface IFilm2
    {
        IEnumerable<Film> SearchFilm(string title);
        IEnumerable<Film> GetFilms();
    }
}