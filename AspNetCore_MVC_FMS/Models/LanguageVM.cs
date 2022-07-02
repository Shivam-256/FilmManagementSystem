using System.Collections.Generic;

namespace AspNetCore_MVC_FMS.Models
{
    public class LanguageVM
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FilmVM> Films { get; set; }
    }
}
