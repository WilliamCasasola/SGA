using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Generacion
    {
        [Key]
        [Display(Name ="Nombre")]
        public virtual String nombre { set; get; }

        [Display(Name ="Año")]
        public virtual String ano { set; get; }
    }
}