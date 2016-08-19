using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Encuesta
    {

        public virtual DateTime fecha { set; get; }
        public virtual double valoracion { set; get; }
    }
}