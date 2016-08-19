using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Curso:Titulo
    {
        
        [Display(Name ="Código")]
        public virtual String codigoCurso { set; get; }

        [Display(Name ="Fecha de Inicio")]
        public virtual DateTime fechaInicio { set; get; }

        [Display(Name ="Fecha de Finalización")]
        public virtual DateTime fechaFinal { set; get; }

        [Display(Name ="Estado")]
        public virtual String estado { set; get; }

        [Display(Name ="Cantidad de Horas")]
        public virtual int cantidadHoras { set; get; }

        [Display(Name ="Tutores")]
        public virtual List<Tutor> tutores { set; get; }

        [Display(Name ="Calificaciones")]
        public virtual List<Calificacion> calificaciones { set; get; }
    }
}