using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace snowdevil.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }  
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string ProductUrl { get; set; }
        public object Lines { get; internal set; }
    }
}
