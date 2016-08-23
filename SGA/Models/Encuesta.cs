using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Encuesta
    {
        public virtual int EncuestaId { set; get; }

        [Display(Name ="Fecha")]
        public DateTime fecha { set; get; }
        public double valoracion { set; get; }
    }
}