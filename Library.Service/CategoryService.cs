using library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class CategoryService : ICategoryServices
    {

        private readonly ICategoryRepository _categoryRepositor;
        public CategoryService(ICategoryRepository category)
        {
            _categoryRepositor = category;
        }
        public List<Category> GetCategory()
        {
            return _categoryRepositor.GetCategory();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepositor.GetCategoryById(id);
        }

        public Category PostCategory(Category category)
        {
            return _categoryRepositor.PostCategory(category);
        }
        public void putCategory(Category category)
        {

            _categoryRepositor.PutCategory(category);
        }

        public void deleteCategory(int id)
        {
            _categoryRepositor.DeleteCategory(id);
        }
    }
}
