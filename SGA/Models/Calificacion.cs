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
        public int CalificacionId { set; get; }


        [Display(Name = "Curso")]
        public virtual Curso curso { set; get; }
        public String CursoId { set; get; }

        [Display(Name = "Número tarea")]
        public int numero { set; get; }

        [Display(Name ="Tipo")]
        public String tipo { set; get; }

        [Display(Name ="Estudiante")]
        public virtual Estudiante estudiante { set; get; }
        public String ClienteId { set; get; }

        [Display(Name ="Nota")]
        public double nota { set; get; }
    }
}