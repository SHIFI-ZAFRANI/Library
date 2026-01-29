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
        public async Task<List<Category>> GetCategoryAsync()
        {
            return await _category.Categories.ToListAsync()    ;
        }
        public async Task SaveAsync()
        {
            await _category.SaveChangesAsync();
        }
        public async Task< Category> GetCategoryByIdAsync(int id)
        {
            return await _category.Categories.ToList().FirstOrDefaultAsync(s => s.idCategory == id);
        }
        public  Category PostCategory(Category category) {
            _category.Categories.Add(category);
            return category;
        }
        public async Task<Category> PutCategoryAsync(Category category) {

            var index = await GetCategoryByIdAsync(category.idCategory);
            index.nameCategory = category.nameCategory;
            index.idCategory = category.idCategory;
            return index;

            
        }
        public async Task DeleteCategoryAsync(int id) { 
            var index=  await GetCategoryByIdAsync(id);
            _category.Categories.Remove(index);
            
        }



 
    }
        
    
}
