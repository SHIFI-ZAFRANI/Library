using library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Data.Repoistories;

namespace Library.Service
{
    public class BookService : IBookServices
    {
        private readonly IBookRepository _bookRepositor;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepositor = bookRepository;
        }
        public Book GetBookById(int id)
        {
           
            return _bookRepositor.GetBookById(id);
        }

        public List<Book> GetBooks()
        {
            return _bookRepositor.GetBooks();   
        }

        public Book PostBook(Book book)
        {
            return _bookRepositor.PostBook(book);
            
        }
        public void PutBook(Book book) {
            _bookRepositor.PutBook(book);
        }
        public void DeleteBook(int id)
        {
            _bookRepositor.DeleteBook(id);
        }
    }
}
