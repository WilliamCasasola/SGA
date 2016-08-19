using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SGA.Models
{
    public class SGAContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SGAContext() : base("name=SGAContext")
        {
            Database.SetInitializer<SGAContext>(new DropCreateDatabaseAlways<SGAContext>());
        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Administrador> administradores { get; set; }
        public DbSet<Calificacion> calificaciones { get; set; }
        public DbSet<Curso> cursos { get; set; }
        public DbSet<Encuesta> encuestas { get; set; }
        public DbSet<Estudiante> estudiantes { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<Facturado> facturados { get; set; }
        public DbSet<Generacion> generaciones { get; set; }
        public DbSet<Titulo> titulos { get; set; }
        public DbSet<Tutor> tutores { get; set; }

    }
}
