using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RecuperacionMVC.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<TipoOperacion> TipoOperacion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operacion>()
                .Property(e => e.estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .Property(e => e.estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .HasMany(e => e.Operacion)
                .WithRequired(e => e.TipoOperacion)
                .WillCascadeOnDelete(false);
        }
    }
}
