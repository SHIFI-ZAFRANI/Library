using library;
using library.Core.Models;
using Library.Core.Repositories;
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
        public List<Book> GetBooks()
        {
            return _bookRepository.Books;
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.Books.Find(s => s.Id == id);
        }
        public Book PostRecipient(Book recipient)
        {
            _bookRepository.Books.Add(recipient);
            return recipient;
        }

        public void PutBook(Book book)
        {
            var index = book.Id;
            _bookRepository.Books[index].nameBook = book.nameBook;
         
        }

        public void DeleteBook(int id)
        {
            var index = _bookRepository.Books.FindIndex(r => r.Id == id);
            _bookRepository.Books.RemoveAt(index);
        }

    } 
}
