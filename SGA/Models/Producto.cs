using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Producto
    {
        [Key]
        [Display(Name ="Código")]
        public virtual String codigo { set; get; }


        [Display(Name ="Precio")]
        public virtual Double precio { set; get;}
        

    }
}