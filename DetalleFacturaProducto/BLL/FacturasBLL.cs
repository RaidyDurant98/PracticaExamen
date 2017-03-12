using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DetalleFacturaProducto.BLL
{
    public class FacturasBLL
    {
        public static bool Guardar(Entidades.Facturas factura)
        {

            using(var Context = new DAL.Respository<Entidades.Facturas>())
            {
                try
                {
                    return Context.Guardar(factura);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool GuardarBLL(Entidades.Facturas factura)
        {
            using (var conec = new DAL.FacturacionDb())
            {
                try
                {
                    conec.Factura.Add(factura);

                    foreach (var g in factura.Productos)
                    {
                        conec.Entry(g).State = System.Data.Entity.EntityState.Unchanged;
                    }

                    conec.SaveChanges();

                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static Entidades.Facturas Buscar(int id)
        {
            var factura = new Entidades.Facturas();

            using (var conec = new DAL.FacturacionDb())
            {
                try
                {
                    factura = conec.Factura.Find(id);
                    factura.Productos.Count();
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return factura;
        }

        public static bool Modificar(Entidades.Facturas factura)
        {
            using (var Context = new DAL.Respository<Entidades.Facturas>())
            {
                try
                {
                    return Context.Modificar(factura);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Eliminar(Entidades.Facturas factura)
        {
            using (var Context = new DAL.Respository<Entidades.Facturas>())
            {
                try
                {
                    return Context.Eliminar(factura);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static Entidades.Facturas Buscar(Expression<Func<Entidades.Facturas, bool>> criterio)
        {
            using (var Context = new DAL.Respository<Entidades.Facturas>())
            {
                try
                {
                    return Context.Buscar(criterio);                 
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return null;
        }

        public static List<Entidades.Facturas> Lista(Expression<Func<Entidades.Facturas, bool>> criterio)
        {
            using (var Context = new DAL.Respository<Entidades.Facturas>())
            {
                try
                {
                    return Context.Lista(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return null;
        }

        public static List<Entidades.Facturas> ListaTodo()
        {
            using (var Context = new DAL.Respository<Entidades.Facturas>())
            {
                try
                {
                    return Context.ListaTodo();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return null;
        }
    }
}
