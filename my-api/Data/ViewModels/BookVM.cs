﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string CoverPhoto { get; set; }
        public int PublisherId { get; set; }
        public List<int> AuthorIds { get; set; }

    }
    public class BookVMwithAuthor
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string CoverPhoto { get; set; }
        public string PublisherNames { get; set; }
        public List<string> AuthorNames { get; set; }

    }
}
