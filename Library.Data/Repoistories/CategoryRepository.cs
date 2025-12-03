using library.Core.Models;
using Library.Core.Repositories;
using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Core.Repositories;

namespace Library.Data.Repoistories
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly DataContext _category;

      

        public CategoryRepository(DataContext context)
        {
            _category = context;
        }
        public List<Category> GetCategory()
        {
            return _category.Categories;
        }

        public Category GetCategoryById(int id)
        {
            return _category.Categories.Find(s => s.idCategory == id);
        }
        public Category PostCategory(Category category) {
            _category.Categories.Add(category);
            return category;
        }
        public void PutCategory(Category category) {

            var index = category.idCategory;
            _category.Categories[index].nameCategory = category.nameCategory;
            _category.Categories[index].idCategory = category.idCategory;
            
        }
        public void DeleteCategory(int id) { 
            var index=_category.Categories.FindIndex(s => s.idCategory == id);
            _category.Categories.RemoveAt(index);
        }



 
    }
        
    
}
