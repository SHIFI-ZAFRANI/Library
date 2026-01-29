using library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface ICategoryServices
    {

        public Task< List<Category>> GetCategoryAsync();
        public  Task< Category> GetCategoryByIdAsync(int id);
        public Task< Category> PostCategoryAsync(Category category);
        public Task<Category> putCategoryAsync(Category category);
        public Task deleteCategoryAsync(int id);
    }
}
