﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public interface ICrudRepository<T>
    {
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        bool Crear(T entity);
        bool Update(T entity);
        bool Eliminar(int id);
    }
}
