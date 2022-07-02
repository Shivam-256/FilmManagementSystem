using System;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Data
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
