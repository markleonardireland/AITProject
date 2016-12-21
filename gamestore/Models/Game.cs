using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestore.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<Transaction> Enrollments { get; set; }
    }
}