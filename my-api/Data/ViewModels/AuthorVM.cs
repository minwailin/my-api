using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.ViewModels
{
    public class AuthorVM
    {
        public string Name { get; set; }
    }

    public class Author_BookVM
    {
        public string Name { get; set; }
        public List<string> BookTitles { get; set; }
    }
}
