using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace One_to_Many.Models
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}