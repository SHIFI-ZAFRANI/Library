using library.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace library
{
    public class DataContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DataContext()
        //{
        //    Books = new List<Book> { new Book { Id = 1, nameBook = "yozavsad" } };
        //    Users = new List<User> { new User { password = 123, name = "shifi", email = "123@gmail.com", phone = "0556793910" } };
        //    Categories = new List<Category> { new Category { idCategory = 1, nameCategory = "metach" } };
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;database=library_db");
        }


    }
}