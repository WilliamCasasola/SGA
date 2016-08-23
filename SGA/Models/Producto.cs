using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public abstract class Producto
    {
        [Display(Name ="Código")]
        public String ProductoId { set; get; }


        [Display(Name ="Precio")]
        public Double precio { set; get;}

        public virtual ICollection<Titulo> titulos { set; get; }
        

    }
}