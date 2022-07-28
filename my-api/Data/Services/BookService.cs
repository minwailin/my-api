using my_api.Data.ViewModels;
using my_api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.Services
{
    public class BookService
    {
        private AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM bookVm)
        {
            var _book = new Book()
            {
                Title = bookVm.Title,
                Description = bookVm.Description,
                IsRead = bookVm.IsRead,
                DateRead = bookVm.IsRead ? bookVm.DateRead.Value : null,
                Rate = bookVm.IsRead ? bookVm.Rate : null,
                CoverPhoto = bookVm.CoverPhoto,
                DateAdded = DateTime.Now,
                PublisherId = bookVm.PublisherId,
                
            };
            _context.Books.Add(_book);
            _context.SaveChanges();

            //Books_Authors.>>Add
            foreach (var id in bookVm.AuthorIds)
            {
                var _book_author = new Book_Author()
                {
                    BookId = _book.id,
                    AuthorId = id
                };
                _context.Books_Authors.Add(_book_author);
                _context.SaveChanges();
            }
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }
        public BookVMwithAuthor GetBookByID(int bid)
        {
            var _bookWithAuthors = _context.Books.Where(n => n.id == bid).Select(bookVm => new BookVMwithAuthor()
            {
                Title = bookVm.Title,
                Description = bookVm.Description,
                IsRead = bookVm.IsRead,
                DateRead = bookVm.IsRead ? bookVm.DateRead.Value : null,
                Rate = bookVm.IsRead ? bookVm.Rate : null,
                CoverPhoto = bookVm.CoverPhoto,
                PublisherNames = bookVm.Publisher.PName,
                AuthorNames = bookVm.Book_Authors.Select(n => n.Author.Name).ToList()
            }).FirstOrDefault();
            return _bookWithAuthors;
         }

        public Book UpdateBookByID(int id ,BookVM bookVm)
        {   
            var book =_context.Books.Find(id); 
            if (book != null)
            {
                book.Title = bookVm.Title;
                book.Description = bookVm.Description;
                book.IsRead = bookVm.IsRead;
                if(book.IsRead == true && bookVm.DateRead == null)
                { bookVm.DateRead = DateTime.Now; }
                book.DateRead = bookVm.IsRead ? bookVm.DateRead.Value : null;
                book.Rate = bookVm.IsRead ? bookVm.Rate : null;
                book.CoverPhoto = bookVm.CoverPhoto;
                _context.SaveChanges();
            }
            return book;  
        }
        public void DeleteBookByID(int Id)
        {
            var DelBook = _context.Books.Find(Id);
            if(DelBook != null)
            {
                _context.Books.Remove(DelBook);
                _context.SaveChanges();
            }


        }
    }
}
