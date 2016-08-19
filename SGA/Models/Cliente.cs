using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Cliente
    {
        [Key]
        public virtual String clave { set; get; }

        [Required]
        [StringLength(70)]
        [Display(Name = "Nombre")]
        public virtual String nombre  { set; get; }

        [Required]
        [StringLength(70)]
        [Display(Name = "País")]
        public virtual String pais { set; get; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Teléfono")]
        public virtual String telefono { set; get; }

        [Required]
        [StringLength(70)]
        [Display(Name = "Correo")]
        public virtual String correo { set; get; }

        [Required]
        [StringLength(70)]
        [Display(Name = "Dirección")]
        public virtual String direccion { set; get; }
    }
}