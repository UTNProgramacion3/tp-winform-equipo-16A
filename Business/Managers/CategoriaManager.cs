using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class CategoriaManager : ICrudRepository<Categoria>
    {
        private DBManager dbManager;

        public CategoriaManager()
        {
            dbManager = new DBManager();
        }

        public void Crear(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Categoria ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
