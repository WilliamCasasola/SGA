using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Curso:Titulo
    {
        [Display(Name ="Código")]
        public String codigoCurso { set; get; }

       // [ForeignKey("TituloId")]
        public virtual Titulo titulo { set; get; }

        [Display(Name ="Fecha de Inicio")]
        public DateTime fechaInicio { set; get; }

        [Display(Name ="Fecha de Finalización")]
        public DateTime fechaFinal { set; get; }

        [Display(Name ="Estado")]
        public String estado { set; get; }

        [Display(Name ="Cantidad de Horas")]
        public int cantidadHoras { set; get; }

        [Display(Name ="Tutores")]
        public virtual ICollection<Tutor> tutores { set; get; }

        [Display(Name ="Calificaciones")]
        public virtual ICollection<Calificacion> calificaciones { set; get; }

        public virtual String codigoCarnet { set; get; }
        [Display(Name ="Estudiantes")]
        public virtual ICollection<Estudiante> estudiantes { set; get; }
    

        [Display(Name ="Generaciones")]
        public virtual ICollection<Generacion> generaciones { set; get; }
    }
}