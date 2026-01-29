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
        public async Task<Book> GetBookByIdAsync(int id)
        {

            return await _bookRepositor.GetBookByIdAsync(id);
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _bookRepositor.GetBooksAsync();
        }

        public async Task<Book> PostBookAsync(Book book)
        {
            var b = _bookRepositor.PostBook(book);
            await _bookRepositor.SaveAsync();
            return b;

        }
        public void PutBookAsync(Book book)
        {
            _bookRepositor.PutBookAsync(book);
            _bookRepositor.SaveAsync();
        }
        public void DeleteBookAsync(int id)
        {
            _bookRepositor.DeleteBookAsync(id);



            _bookRepositor.SaveAsync();
        }
    }
}
