﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Titulo:Producto
    {
        [Required]
        [Display(Name ="Nombre")]
        public virtual String nombre { set; get; }

        [Display(Name="Foto")]
        public virtual String rutaFoto { set; get; }

    }
}