using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Facturado
    {
        [Key]
        public virtual int id { set; get; }
        public virtual Estudiante estudiante { set; get; }
        public virtual List<Producto> productos { set; get; }
    }
}