using System.Collections.Generic;

namespace AspNetCore_MVC_FMS.Models
{
    public class CategoryVM
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FilmVM> Films { get; set; }
    }
}
