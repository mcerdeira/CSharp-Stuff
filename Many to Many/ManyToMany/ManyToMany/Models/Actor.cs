using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyToMany.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }        

        public virtual ICollection<MovieActors> MovieActors { get; set; }
    }
}