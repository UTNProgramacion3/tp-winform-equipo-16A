using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public interface ICrudRepository<T>
    {
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        void Crear(T entity);
        void Update(T entity);
        void Eliminar(T entity);
    }
}
