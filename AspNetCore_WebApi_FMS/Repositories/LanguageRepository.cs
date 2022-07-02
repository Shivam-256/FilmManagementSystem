using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public class LanguageRepository : ILanguage
    {
        private FMSDbContext _db;
        public LanguageRepository(FMSDbContext context)
        {
            this._db = context;
        }
        public Language AddLanguage(Language lng)
        {
            _db.Languages.Add(lng);
            _db.SaveChanges();
            return lng;
        }

        public bool DeleteLanguage(int languageId)
        {
            var lng = _db.Languages.FirstOrDefault(l => l.LanguageId == languageId);
            if (lng != null)
            {
                _db.Languages.Remove(lng);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Language> GetLanguages()
        {
            var lngList = _db.Languages;
            return lngList;
        }

        public Language SearchLanguage(int languageId)
        {
            var lng = _db.Languages.FirstOrDefault(l => l.LanguageId == languageId);
            if (lng != null)
                return lng;
            else
                return null;
        }


        public void UpdateLanguage(int languageId, Language lng)
        {
            var newLng = _db.Languages.FirstOrDefault(l => l.LanguageId == languageId);
            if (newLng != null)
            {
               // newLng.LanguageId = lng.LanguageId;
                newLng.Name = lng.Name;
                _db.SaveChanges();
            }
        }
    }
}