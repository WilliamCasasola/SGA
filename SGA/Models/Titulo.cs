using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Titulo:Producto
    {
      
        public virtual Producto producto { set; get; }

        [Required]
        [Display(Name ="Nombre")]
        public String nombre { set; get; }

        [Display(Name="Foto")]
        public String rutaFoto { set; get; }

        public virtual ICollection<Curso> cursos { set; get; }

        //[ForeignKey("ProductoId")]
        //public virtual Producto producto { set; get; }

    }
}