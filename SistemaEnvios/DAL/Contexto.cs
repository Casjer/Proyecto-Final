using SistemaEnvios.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SistemaEnvios.DAL
{
   public  class Contexto : DbContext
    {
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Monedas> Moneda { get; set; }
        public DbSet<EntradaMonedas> entradaMoneda { get; set; }
        public DbSet<Envios> Envio { get; set; }

        public DbSet<EnviosDetalles> Detalles { get; set; }
        public Contexto() : base("ConStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
