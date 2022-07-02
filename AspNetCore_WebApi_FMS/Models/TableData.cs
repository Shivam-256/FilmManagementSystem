using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Models
{
    public class TableData
    {

        public List<Category> Categories { get; set; }
        public List<Language> Languages { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
