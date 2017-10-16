using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace One_to_Many.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Apellido")]
        public string SurName { get; set; }
        [DisplayName("Empresa")]
        public int EmpresaId { get; set; }
        [DisplayName("Empresa")]
        public virtual Empresa Empresa { get; set; }
    }
}