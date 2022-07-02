using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
using System.Linq;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public class CategoryRepository2 : ICategory2
    {
        private FMSDbContext _db;
        public CategoryRepository2(FMSDbContext context)
        {
            this._db = context;
        }
        public IEnumerable<Category> GetCategories()
        {
            var cgyList = _db.Categories;
            return cgyList;
        }

    }
}