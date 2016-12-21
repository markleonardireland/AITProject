﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestore.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime ReviewDate { get; set; }

        public virtual Game Game { get; set; }
    }
}