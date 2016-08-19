using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Administrador:Persona
    {
        [Display(Name ="Morosos")]
        public virtual List<Cliente> morosos { set; get; }

        [Display(Name ="Congelados")]
        public virtual List<Estudiante> congelados { set; get; }
    }
}