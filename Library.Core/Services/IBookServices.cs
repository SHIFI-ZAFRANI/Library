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

        
        public List<Book> GetBooks();
        public Book GetBookById(int id);
        public Book PostBook(Book book);
    
        public void DeleteBook(int id);
        public void PutBook(Book book); 


    }
}
