using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DetalleFacturaProducto.Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }

        public virtual List<Entidades.Facturas> Facturas { get; set; }

        public Productos()
        {
            this.Facturas = new List<Entidades.Facturas>();
        }
    }
}
