using DataAccess;
using Domain.Entities;
using Utils;
using Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Business.Managers
{
    public class ArticuloManager : ICrudRepository<Articulo>
    {
        private DBManager _dbManager;
        private IMapper<Articulo> _mapper;

        public ArticuloManager()
        {
            _dbManager = new DBManager();
            _mapper = new Mapper<Articulo>();
        }

        public bool Crear(Articulo entity)
        {
            string query = @"Insert into ARTICULOS values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Codigo", entity.Codigo),
                    new SqlParameter("@Nombre", entity.Nombre),
                    new SqlParameter("@Descripcion", entity.Descripcion),
                    new SqlParameter("@IdMarca", entity.IdMarca),
                    new SqlParameter("@IdCategoria", entity.IdCategoria),
                    new SqlParameter("@Precio", entity.Precio)
                };

            var res = _dbManager.ExecuteNonQuery(query, parametros);

            if (res == 0)
            {
                return false;
            }

            return true;
        }

        public bool Eliminar(int id)
        {
            //Eliminacion virtual:
            //      Cambiamos el codigo del art a eliminar a 0000.
            string query = @"Update ARTICULOS
                            Set Codigo = @Codigo
                            Where Id = @Id";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Codigo", "0000"),
                    new SqlParameter("@Id", id)
                };

            var res = _dbManager.ExecuteNonQuery(query, parametros);

            if (res == 0)
            {
                return false;
            }

            return true;
        }
        public Articulo ObtenerPorId(int id)
        {
            string query = @"Select * From ARTICULO Where Id = @Id";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

            DataTable res = _dbManager.ExecuteQuery(query, parametros);

            if (res.Rows.Count == 0)
            {
                return null;
            }

            var articulo = _mapper.MapFromRow(res.Rows[0]);

            return articulo;

        }

        public List<Articulo> ObtenerTodos()
        {
            string query = @"Select * from ARTICULOS";

            DataTable res = _dbManager.ExecuteQuery(query);

            if (res.Rows.Count == 0)
            {
                return null;
            }

            var articulosList = _mapper.ListMapFromRow(res);

            return articulosList;
        }

        public bool Update(Articulo entity)
        {
            string query = @"Update ARTICULOS 
                            Set Codigo = @Codigo,
                                Nombre = @Nombre,
                                Descripcion = @Descripcion,
                                IdMarca = @IdMarca,
                                IdCategoria = @IdCategoria,
                                Precio = @Precio
                            Where Id = @Id";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Codigo", entity.Codigo),
                    new SqlParameter("@Nombre", entity.Nombre),
                    new SqlParameter("@Descripcion", entity.Descripcion),
                    new SqlParameter("@IdMarca", entity.IdMarca),
                    new SqlParameter("@IdCategoria", entity.IdCategoria),
                    new SqlParameter("@Precio", entity.Precio)
                };

            var res = _dbManager.ExecuteNonQuery(query, parametros);

            if(res == 0)
            {
                return false;
            }

            return true;

        }

    }
}
