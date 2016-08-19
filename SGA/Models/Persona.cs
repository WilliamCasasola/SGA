using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Persona : Cliente
    {
      
        [Required]
        [StringLength(70)]
        [Display(Name = "Apellidos")]
        public virtual String apellidos { set; get; }

        [StringLength(4, ErrorMessage = "Máximo x dígitos.")]
        [Column("Contraseña")]
        public virtual String contrasena { set; get; }

        [Required]
        [Display(Name = "Sexo")]
        public virtual Boolean sexo { set; get; }

        [Required]
        [Display(Name = "Profesión")]
        public virtual String profesion { set; get; }

        [Required]
        [Display(Name = "Institución")]
        public virtual String institucion { set; get; }

        [Display(Name ="Foto")]
        public virtual String rutaFoto { set; get; }

        [Required]
        [Display(Name = "Correo Alternativo")]
        public virtual String correoAlternativo { set; get; }
    }
}