using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Encuesta
    {
        [Key]
        public virtual int id { set; get; }
        public virtual DateTime fecha { set; get; }
        public virtual double valoracion { set; get; }
    }
}