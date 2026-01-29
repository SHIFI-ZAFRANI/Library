using library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetCategoryAsync();
        public Task <Category> GetCategoryByIdAsync(int id);
        public Category PostCategory(Category category);
        public Task DeleteCategoryAsync(int id);
        public Task<Category> PutCategoryAsync(Category category);
        public Task SaveAsync();
    }
}
