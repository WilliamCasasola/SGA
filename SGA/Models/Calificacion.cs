using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Calificacion
    {
        [Key]
        [Display(Name = "Curso")]
        public virtual Curso curso { set; get; }

        [Key]
        [Display(Name = "Número tarea")]
        public virtual int numero { set; get; }

        [Display(Name ="Tipo")]
        public virtual String tipo { set; get; }

        [Key]
        [Display(Name ="Estudiante")]
        public virtual Estudiante estudiante { set; get; }

        [Display(Name ="Nota")]
        public virtual double nota { set; get; }
    }
}