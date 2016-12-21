using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gamestore.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int GameID { get; set; }
        public DateTime TransactionDate { get; set; }

        public virtual User User { get; set; }
        public virtual Games Game { get; set; }
    }
}