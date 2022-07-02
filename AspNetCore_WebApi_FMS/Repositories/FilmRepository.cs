using AspNetCore_WebApi_FMS.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public class FilmRepository : IFilm
    {
        private FMSDbContext _db;
        public FilmRepository(FMSDbContext context)
        {
            this._db = context;
        }
        public Film AddFilm(Film fm)
        {
            _db.Films.Add(fm);
            _db.SaveChanges();
            return fm;
        }

          //  For Delete Method
        public bool DeleteFilm(int filmId)
        {
            var fm = _db.Films.FirstOrDefault(f => f.FilmId == filmId);
            if(fm != null)
            {
                _db.Films.Remove(fm);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        // For Get Film List
        public IEnumerable<Film> GetFilms()
        { 
            var fmList = _db.Films.Include(f => f.Actor).Include(f => f.Language).Include(f => f.Category);
         
            return fmList;
        }

        //  For Search Method
        public IEnumerable<Film> SearchFilm(string title)
        {
            var fm = _db.Films.Where(t => t.Title.Contains(title));
            if (fm != null)
                return fm;
            else
                return null;  
        }

        public Film SearchFilm(int releaseYear)
        {
            var fm = _db.Films.FirstOrDefault(ry => ry.ReleaseYear == releaseYear);
            if (fm != null)
                return fm;
            else
                return null;
        }

        public Film SearchFilm(decimal rating)
        {
            var fm = _db.Films.FirstOrDefault(r => r.Rating == rating);
            if (fm != null)
                return fm;
            else
                return null;
        }

         // For Update Method

        public void UpdateFilm(int filmId, Film fm)
        {
            var newFm = _db.Films.FirstOrDefault(f => f.FilmId == filmId);
            if (newFm != null)
            {
                newFm.FilmId = fm.FilmId;
                newFm.Description = fm.Description;
                newFm.Title = fm.Title;
                newFm.ReleaseYear = fm.ReleaseYear;
                newFm.LanguageId = fm.LanguageId;
                newFm.RentalDuration = fm.RentalDuration;
                newFm.Length = fm.Length;
                newFm.ReplacementCost = fm.ReplacementCost;
                newFm.Rating = fm.Rating;
                newFm.SpecialFeatures = fm.SpecialFeatures;
                newFm.ActorId = fm.ActorId;
                newFm.CategoryId = fm.CategoryId;
                _db.SaveChanges();
            }
        }
    }
}
