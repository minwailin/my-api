using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.ViewModels
{
    public class PublisherVM
    {
        public string PName { get; set; }
    }
    public class PublisherVMForAthuor_Books
    {
        public string PName { get; set; }
        public List<BookAuthorVMForPublisher> BookAuthors { get; set; }
    }
    public class BookAuthorVMForPublisher
    {
        public string BookName { get; set; }
        public List<string> BookAuthors { get; set; }
    }


}
