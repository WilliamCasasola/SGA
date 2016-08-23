using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Facturado
    {
        public int FacturadoId { set; get; }

        [Display(Name ="Estudiante")]
        public virtual Estudiante estudiante { set; get; }
        public String ClienteId { set; get; }


        [Display(Name = "Productos")]
        public virtual ICollection<Producto> productos { set; get; }
    }
}