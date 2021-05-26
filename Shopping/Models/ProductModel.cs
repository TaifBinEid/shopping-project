﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Models
{
    public class ProductModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Author { get; set;  }
        public string Image { get; set; }

    }
}
