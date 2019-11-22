﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace angularclient.Models
{
    public class Category
    {
        [Key]
        public int Code { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
