using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class ArticuloManager : ICrudRepository<Articulo>
    {
        private DBManager dbManager;

        public ArticuloManager()
        {
            dbManager = new DBManager();
        }

        public void Crear(Articulo entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Articulo entity)
        {
            throw new NotImplementedException();
        }
        public Articulo ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Articulo> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public void Update(Articulo entity)
        {
            throw new NotImplementedException();
        }
    }
}
