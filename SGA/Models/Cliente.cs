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
        public String clave { set; get; }
        [Required]
        [StringLength(70)]
        [Display(Name = "Nombre")]
        public String nombre  { set; get; }
        [Required]
        [StringLength(70)]
        [Display(Name = "País")]
        public String pais { set; get; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Teléfono")]
        public String telefono { set; get; }
        [Required]
        [StringLength(70)]
        [Display(Name = "Correo")]
        public String correo { set; get; }
        [Required]
        [StringLength(70)]
        [Display(Name = "Dirección")]
        public String direccion { set; get; }
    }
}