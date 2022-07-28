using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string CoverPhoto { get; set; }
        public DateTime DateAdded { get; set; }



        //Naviagation
        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }


        public List<Book_Author> Book_Authors { get; set; }
    }
}
