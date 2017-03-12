using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DetalleFacturaProducto.DAL
{
    public class FacturacionDb : DbContext
    {
        public FacturacionDb() : base("ConStr")
        {

        }

        public DbSet<Entidades.Facturas> Factura { get; set; }
        public DbSet<Entidades.Productos> Producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Productos>()
                .HasMany(producto => producto.Facturas)
                .WithMany(Factura => Factura.Productos)
                .Map(facturaProducto =>
                {
                    facturaProducto.MapLeftKey("FacturaId");
                    facturaProducto.MapRightKey("ProductoId");
                    facturaProducto.ToTable("FacturasProductos");
                });
        }
    }
}
