using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.Models
{
    public class Book_Author
    {
        public int id { get; set; }

        
        public int BookId { get; set; } //For Book
        public Book Book { get; set; }

        public int AuthorId { get; set; } //ForAuthor
        public Author Author { get; set; }

    }
}
