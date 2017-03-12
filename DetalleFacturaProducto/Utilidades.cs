using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetalleFacturaProducto
{
    public class Utilidades
    {
        public static int TOINT(string num)
        {
            int numero = 0;
            int.TryParse(num, out numero);
            return numero;
        }

        public static float TOFLOAT(string num)
        {
            float numero = 0.0f;
            float.TryParse(num, out numero);
            return numero;
        }
    }
}
