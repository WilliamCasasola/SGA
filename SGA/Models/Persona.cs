using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public abstract class Persona : Cliente
    {
      
        [Required]
        [StringLength(70)]
        [Display(Name = "Apellidos")]
        public String apellidos { set; get; }

        [StringLength(4, ErrorMessage = "Máximo x dígitos.")]
        [Column("Contraseña")]
        public String contrasena { set; get; }

        [Required]
        [Display(Name = "Sexo")]
        public Boolean sexo { set; get; }

        [Required]
        [Display(Name = "Profesión")]
        public String profesion { set; get; }

        [Required]
        [Display(Name = "Institución")]
        public String institucion { set; get; }

        [Display(Name ="Foto")]
        public String rutaFoto { set; get; }

        [Required]
        [Display(Name = "Correo Alternativo")]
        public String correoAlternativo { set; get; }
    }
}