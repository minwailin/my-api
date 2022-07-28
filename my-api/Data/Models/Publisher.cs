﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PName { get; set; }

        //navigation
        public List<Book> Books { get; set; }
    }
}
