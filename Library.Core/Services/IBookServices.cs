using library.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public interface IBookServices
    {

        
        public Task<List<Book>> GetBooksAsync();
        public Task< Book> GetBookByIdAsync(int id);
        public Task<Book> PostBookAsync(Book book);
    
        public Task DeleteBookAsync(int id);
        public Task<Book> PutBookAsync(Book book); 


    }
}
