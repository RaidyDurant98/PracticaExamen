using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DetalleFacturaProducto.DAL
{
    public interface IRespository<TEntity> : IDisposable where TEntity : class 
    {
        bool Guardar(TEntity laEntidad);
        bool Eliminar(TEntity laEntidad);
        bool Modificar(TEntity laEntidad);
        TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda);
        List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda);
        List<TEntity> ListaTodo();
    }
}
