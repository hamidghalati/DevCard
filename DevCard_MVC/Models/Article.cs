﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Article(long id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
