﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
    }
}