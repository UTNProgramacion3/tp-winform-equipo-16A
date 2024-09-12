using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Utils;
using Utils.Interfaces;

namespace Business.Managers
{
    public class CategoriaManager : ICrudRepository<Categoria>
    {
        private DBManager _dbManager;
        private IMapper<Categoria> _mapper;

        public CategoriaManager()
        {
            _dbManager = new DBManager();
            _mapper = new Mapper<Categoria>();
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
            string query = "SELECT * FROM Categorias WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[] 
            { new SqlParameter("@Id", id) };

            DataTable res = _dbManager.ExecuteQuery(query, parameters);

            if(res.Rows.Count == 0)
            {
                return null;
            }

            var categoria = _mapper.MapFromRow(res.Rows[0]);

            return categoria;
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
