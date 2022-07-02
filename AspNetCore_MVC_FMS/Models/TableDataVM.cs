using System.Collections.Generic;
namespace AspNetCore_MVC_FMS.Models
{
    public class TableDataVM
    {
        public List<CategoryVM> Categories { get; set; }
        public List<LanguageVM> Languages { get; set; }
        public List<ActorVM> Actors { get; set; }
    }
}
