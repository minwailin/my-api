using my_api.Data.Models;
using my_api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.Services
{
    public class AuthorService
    {
        private readonly AppDbContext _context;

        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(AuthorVM authorVM)
        {
            var author = new Author()
            {
                Name = authorVM.Name
            };
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public Author_BookVM GetAuthorWithBook(int Authorid)
        {
            var authors = _context.Authors.Where(n => n.id == Authorid).Select(n => new Author_BookVM()
            {
                Name = n.Name,
                BookTitles = n.Book_Authors.Select(n => n.Book.Title).ToList()
            }).FirstOrDefault();
            return authors;
        }
    }
}
