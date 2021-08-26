using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProyectoAnalisis.Model;

namespace ProyectoAnalisis.DB
{
    public class Context : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model.AspNetUsers>().ToTable("AspNetUsers");
            modelBuilder.Entity<Model.Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Model.Usuarios>().ToTable("Usuarios"); 
            modelBuilder.Entity<Model.LineaDeDetalle>().ToTable("LineaDeDetalle");
            modelBuilder.Entity<Model.Producto>().ToTable("Producto");
            modelBuilder.Entity<Model.Encabezado>().ToTable("Encabezado");
            modelBuilder.Entity<Model.Emisor>().ToTable("Emisor");
            modelBuilder.Entity<Model.Receptor>().ToTable("Receptor");
            modelBuilder.Entity<Model.Telefono>().ToTable("Telefono");
            modelBuilder.Entity<Model.Identificacion>().ToTable("Identificacion");
            modelBuilder.Entity<Model.Ubicacion>().ToTable("Ubicacion");
            modelBuilder.Entity<Model.Provincia>().ToTable("Provincia");
            modelBuilder.Entity<Model.Canton>().ToTable("Canton");
            modelBuilder.Entity<Model.Distrito>().ToTable("Distrito");
            modelBuilder.Entity<Model.Cierres>().ToTable("Cierres");
            modelBuilder.Entity<Model.Factura>().ToTable("Factura");
        }
        public DbSet<Model.AspNetUsers> AspNetUsers { get; set; }
        public DbSet<Model.Usuarios> Usuarios
        {
            get; set;
        }
        public DbSet<Model.LineaDeDetalle> LineaDeDetalle { get; set; }
        public DbSet<Model.Producto> Producto { get; set; }
        public DbSet<Model.Encabezado> Encabezado { get; set; }
        public DbSet<Model.Emisor> Emisor { get; set; }
        public DbSet<Model.Receptor> Receptor { get; set; }
        public DbSet<Model.Telefono> Telefono { get; set; }
        public DbSet<Model.Identificacion> Identificacion { get; set; }
        public DbSet<Model.Ubicacion> Ubicacion { get; set; }
        public DbSet<Model.Provincia> Provincia { get; set; }
        public DbSet<Model.Canton> Canton { get; set; }
        public DbSet<Model.Distrito> Distrito { get; set; }
        public DbSet<Model.Cliente> Cliente { get; set; }
        public DbSet<Model.Cierres> Cierres { get; set; }
        public DbSet<Model.Factura> Factura { get; set; }
    }
}
