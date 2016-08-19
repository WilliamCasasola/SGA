using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Facturado
    {
        public virtual Estudiante estudiante { set; get; }
        public virtual List<Producto> productos { set; get; }
    }
}