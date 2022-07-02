using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore_WebApi_FMS.Repositories
{
    public class CategoryRepository : ICategory
    {
        private FMSDbContext _db;
        public CategoryRepository(FMSDbContext context)
        {
            this._db = context;
        }
        public Category AddCategory(Category cgy)
        {
            _db.Categories.Add(cgy);
            _db.SaveChanges();
            return cgy;
        }

        public bool DeleteCategory(int categoryId)
        {
            var cgy = _db.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (cgy != null)
            {
                _db.Categories.Remove(cgy);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Category> GetCategories()
        {
            var cgyList = _db.Categories;
            return cgyList;
        }

        public Category SearchCategory(int categoryId)
        {
            var cgy = _db.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (cgy != null)
                return cgy;
            else
                return null;
        }

        public void UpdateCategory(int categoryId, Category cgy)
        {
            var newCgy = _db.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if (newCgy != null)
            {
                newCgy.CategoryId = cgy.CategoryId;
                newCgy.Name = cgy.Name;
                _db.SaveChanges();
            }
        }
    }
}
