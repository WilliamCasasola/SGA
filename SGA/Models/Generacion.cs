using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Generacion
    {
        [Display(Name ="Nombre")]
        public String GeneracionId { set; get; }

        [Display(Name ="Año")]
        public String ano { set; get; }

        public virtual ICollection<Curso> cursos { set;  get; }
    }
}