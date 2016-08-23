using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Factura
    {
        [Display(Name ="Número de Factura")]
        public int FacturaId { set; get; }

        [Display(Name ="Fecha")]
        public DateTime fecha { set; get; }

        [Display(Name ="Descripción")]
        public String descripcion { set; get; }

        [Display(Name ="Cancelado")]
        public Boolean cancelado { set;  get; }

        [Display(Name ="Cliente")]
        public virtual Cliente cliente { set; get; }
        public virtual String ClienteId { set; get; }


        [Display(Name ="Facturados")]
        public virtual ICollection<Facturado> facturados { set; get; }

    }
}