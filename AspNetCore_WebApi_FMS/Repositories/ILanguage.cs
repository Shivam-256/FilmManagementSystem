using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface ILanguage
    {
        Language AddLanguage(Language lng);
        void UpdateLanguage(int languageId, Language lng);
        bool DeleteLanguage(int languageId);
        Language SearchLanguage(int languageId);
        IEnumerable<Language> GetLanguages();
    }
}
