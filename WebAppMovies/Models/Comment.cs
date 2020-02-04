﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMovies.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string Text { get; set; }

        public DateTime AddedDate { get; set; }
        public Comment()
        {

        }
    }
}