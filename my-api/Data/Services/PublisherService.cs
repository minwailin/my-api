using my_api.Data.Models;
using my_api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.Services
{
    public class PublisherService
    {
        private readonly AppDbContext _appDbContext;
        public PublisherService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddPublisher(PublisherVM publisherVM)
        {
            var publisher = new Publisher()
            {
                PName = publisherVM.PName
            };
            _appDbContext.Publishers.Add(publisher);
            _appDbContext.SaveChanges();
        }

        public PublisherVMForAthuor_Books getPublisherById (int Pid)
        {
            var Publisher = _appDbContext.Publishers.Where(n => n.Id == Pid)
                .Select(n => new PublisherVMForAthuor_Books()
                {
                    PName = n.PName,
                    BookAuthors = n.Books.Select(n => new BookAuthorVMForPublisher()
                    {
                        BookName = n.Title,
                        BookAuthors = n.Book_Authors.Select(n => n.Author.Name).ToList()
                    }).ToList()
                }).FirstOrDefault();

            return Publisher;
        }

        public void DeletePublisher(int id)
        {
            var publisher = _appDbContext.Publishers.Find(id);
            _appDbContext.Publishers.Remove(publisher);
            _appDbContext.SaveChanges();
        }
    }
}
