using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestore.Models
{
    public class Games
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Transaction> Enrollments { get; set; }
    }
}