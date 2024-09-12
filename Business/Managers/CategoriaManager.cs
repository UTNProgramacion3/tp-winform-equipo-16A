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
            string query = "INSERT INTO Categorias (Descripcion) VALUES (@Descripcion)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Descripcion", entity.Descripcion)
            };

            _dbManager.ExecuteNonQuery(query, parameters);
        }

        public void Eliminar(Categoria entity)
        {
            string query = "DELETE FROM Categorias WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", entity.Id)
            };

            _dbManager.ExecuteNonQuery(query, parameters);
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
            string query = "SELECT * FROM Categorias";

            DataTable res = _dbManager.ExecuteQuery(query);

            if(res.Rows.Count == 0)
            {
                return null;
            }

            var categoriasList = _mapper.ListMapFromRow(res);

            return categoriasList;

        }

        public void Update(Categoria entity)
        {
            string query = "UPDATE Categorias SET Descripcion = @Descripcion WHERE Id = @Id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Descripcion", entity.Descripcion),
                new SqlParameter("@Id", entity.Id)
            };

            _dbManager.ExecuteNonQuery(query, parameters);
        }
    }
}
