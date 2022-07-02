using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface ILanguage2
    {
        IEnumerable<Language> GetLanguages();
    }
}