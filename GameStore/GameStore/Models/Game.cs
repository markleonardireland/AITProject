using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public string ImageURL { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}