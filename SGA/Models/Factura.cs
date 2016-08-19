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
        [Key]
        [Display(Name ="Número de Factura")]
        public virtual int numeroFactura { set; get; }

        [Display(Name ="Fecha")]
        public virtual DateTime fecha { set; get; }

        [Display(Name ="Descripción")]
        public virtual String descripcion { set; get; }

        [Display(Name ="Cancelado")]
        public virtual Boolean cancelado { set;  get; }

        [ForeignKey("codigo")]
        [Display(Name ="Cliente")]
        public virtual Cliente cliente { set; get; }

        [Display(Name ="Facturados")]
        public virtual ICollection<Facturado> facturados { set; get; }

    }
}