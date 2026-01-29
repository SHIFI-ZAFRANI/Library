using library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repositories
{
    public interface IBookRepository
    {
        public Task< List<Book>> GetBooksAsync();
        public Task< Book> GetBookByIdAsync(int id);
       public Book PostBook(Book book);
        public Task  DeleteBookAsync(int id);
        public Task PutBookAsync(Book book);
        public Task SaveAsync();
    }
}
