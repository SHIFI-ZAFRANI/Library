using library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Data.Repoistories;
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
        public async Task<List<Category>> GetCategoryAsync()
        {
            return await _categoryRepositor.GetCategoryAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepositor.GetCategoryByIdAsync(id);
        }

        public async Task< Category> PostCategoryAsync(Category category)
        {  
            var c= _categoryRepositor.PostCategory(category);
           await _categoryRepositor.SaveAsync();
            return c;

          
        }
        public async Task putCategoryAsync(Category category)
        {

            await _categoryRepositor.PutCategoryAsync(category);
            await _categoryRepositor.SaveAsync();
        }

        public async Task deleteCategoryAsync(int id)
        {
           await _categoryRepositor.DeleteCategoryAsync(id);

          await  _categoryRepositor.SaveAsync();
        }
    }
}
