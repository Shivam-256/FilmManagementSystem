using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
using System.Linq;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public class LanguageRepository2 : ILanguage2
    {
        private FMSDbContext _db;
        public LanguageRepository2(FMSDbContext context)
        {
            this._db = context;
        }
        public IEnumerable<Language> GetLanguages()
        {
            var lngList = _db.Languages;
            return lngList;
        }

    }
}