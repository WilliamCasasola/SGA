using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Calificacion
    {
        [Key]
        [ForeignKey("codigo")]
        [Display(Name = "Curso")]
        public virtual Curso curso { set; get; }

        [Key]
        [Display(Name = "Número tarea")]
        public virtual int numero { set; get; }

        [Display(Name ="Tipo")]
        public virtual String tipo { set; get; }

        [Key]
        [ForeignKey("codigo")]
        [Display(Name ="Estudiante")]
        public virtual Estudiante estudiante { set; get; }

        [Display(Name ="Nota")]
        public virtual double nota { set; get; }
    }
}