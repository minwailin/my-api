using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.Models
{
    public class Author
    {
        public int id { get; set; }
        public string Name { get; set; }

        //Navigation
        public List<Book_Author> Book_Authors { get; set; }
    }
}
