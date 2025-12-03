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
        public List<Category> GetCategory();
        public Category GetCategoryById(int id);
        public Category PostCategory(Category category);
        public void DeleteCategory(int id);
        public void PutCategory(Category category);
    }
}
