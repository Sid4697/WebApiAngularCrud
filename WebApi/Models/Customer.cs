﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int orderTotal { get; set; }
    }
}
