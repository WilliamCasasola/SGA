﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class Tutor:Persona
    {
        [Display(Name ="Cursos")]
        public virtual ICollection<Curso> cursos { set; get; }
    }
}