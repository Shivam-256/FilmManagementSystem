using System;
using AspNetCore_WebApi_FMS.Data;
using System.Collections.Generic;
namespace AspNetCore_WebApi_FMS.Repositories
{
    public interface ICategory
    {
        Category AddCategory(Category cgy);
        void UpdateCategory(int categoryId, Category cgy);
        bool DeleteCategory(int categoryId);
        Category SearchCategory(int categoryId);

        IEnumerable<Category> GetCategories();
    }
}

