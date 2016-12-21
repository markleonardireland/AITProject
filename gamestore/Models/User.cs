using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestore.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}