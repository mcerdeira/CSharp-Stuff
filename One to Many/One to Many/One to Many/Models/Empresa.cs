using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace One_to_Many.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        [DisplayName("Nombre Empresa")]
        public string Name { get; set; }        
    }
}