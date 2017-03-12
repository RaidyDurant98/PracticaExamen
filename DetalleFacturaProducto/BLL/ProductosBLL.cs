using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DetalleFacturaProducto.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Entidades.Productos producto)
        {
            using (var Context = new DAL.Respository<Entidades.Productos>())
            {
                try
                {
                    return Context.Guardar(producto);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Modificar(Entidades.Productos producto)
        {
            using (var Context = new DAL.Respository<Entidades.Productos>())
            {
                try
                {
                    return Context.Modificar(producto);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static bool Eliminar(Entidades.Productos producto)
        {
            using (var Context = new DAL.Respository<Entidades.Productos>())
            {
                try
                {
                    return Context.Eliminar(producto);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return false;
        }

        public static Entidades.Productos Buscar(Expression<Func<Entidades.Productos, bool>> criterio)
        {
            using (var Context = new DAL.Respository<Entidades.Productos>())
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

        public static List<Entidades.Productos> Lista(Expression<Func<Entidades.Productos, bool>> criterio)
        {
            using (var Context = new DAL.Respository<Entidades.Productos>())
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

        public static List<Entidades.Productos> ListaTodo()
        {
            using (var Context = new DAL.Respository<Entidades.Productos>())
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
