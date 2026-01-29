using library;
using library.Core.Models;
using Library.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repoistories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _bookRepository;
        public BookRepository(DataContext context)
        {
            _bookRepository = context;
        }
        public async Task<List<Book>> GetBooksAsync()
        {
            return await _bookRepository.Books.Include(s => s.Category).ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _bookRepository.Books.FirstOrDefaultAsync(s => s.Id == id);
        }



        public Book PostBook(Book book)
        {
            _bookRepository.Books.Add(book);
            return book;
        }

        public async Task<Book> PutBookAsync(Book book)
        {
            var index = await GetBookByIdAsync(book.Id);
            index.nameBook = book.nameBook;
            return index;

        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await GetBookByIdAsync(id);
            _bookRepository.Books.Remove(book);


        }
        public async Task SaveAsync()
        {
            await _bookRepository.SaveChangesAsync();
        }

    }
}
