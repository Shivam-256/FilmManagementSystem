using AspNetCore_WebApi_FMS.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public class FilmRepository2 : IFilm2
    {
        private FMSDbContext _db;
        public FilmRepository2(FMSDbContext context)
        {
            this._db = context;
        }
        public IEnumerable<Film> GetFilms()
        {
            var fmList = _db.Films.Include(f => f.Actor).Include(f => f.Language).Include(f => f.Category);

            return fmList;
        }
        public IEnumerable<Film> SearchFilm(string title)
        {
            var fm = _db.Films.Where(t => t.Title.Contains(title));
            if (fm != null)
                return fm;
            else
                return null;
        }

    }
}
