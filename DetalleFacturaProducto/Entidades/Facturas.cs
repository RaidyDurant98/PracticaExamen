using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DetalleFacturaProducto.Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public decimal Cantidad { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public double Importe { get; set; }

        public virtual List<Entidades.Productos> Productos { get; set; }

        public Facturas()
        {
            this.Productos = new List<Entidades.Productos>();
        }
    }
}
