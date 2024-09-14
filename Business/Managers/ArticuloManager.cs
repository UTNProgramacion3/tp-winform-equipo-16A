using DataAccess;
using Domain.Entities;
using Utils;
using Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Business.Dtos;

namespace Business.Managers
{
    public class ArticuloManager : ICrudRepository<ArticuloDTO>
    {
        private DBManager _dbManager;
        private IMapper<ArticuloDTO> _mapper;

        public ArticuloManager()
        {
            _dbManager = new DBManager();
            _mapper = new Mapper<ArticuloDTO>();
        }

        public bool Crear(ArticuloDTO entity)
        {
            string query = @"Insert into ARTICULOS values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Codigo", entity.Articulo.Codigo),
                    new SqlParameter("@Nombre", entity.Articulo.Nombre),
                    new SqlParameter("@Descripcion", entity.Articulo.Descripcion),
                    new SqlParameter("@IdMarca", entity.Articulo.IdMarca),
                    new SqlParameter("@IdCategoria", entity.Articulo.IdCategoria),
                    new SqlParameter("@Precio", entity.Articulo.Precio)
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
        public ArticuloDTO ObtenerPorId(int id)
        {
            string query = @"SELECT 
                                A.Id,
                                A.Codigo,
                                A.Nombre,
                                A.Descripcion,
                                A.Precio,
                                M.Id AS MarcaId,
                                M.Descripcion AS MarcaDescripcion,
                                C.Id AS CategoriaId,
                                C.Descripcion AS CategoriaDescripcion
                            FROM ARTICULOS A
                            JOIN MARCAS M ON A.IdMarca = M.Id
                            JOIN CATEGORIAS C ON A.IdCategoria = C.Id
                            WHERE A.Id = @Id;";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

            DataTable res = _dbManager.ExecuteQuery(query, parametros);

            if (res.Rows.Count == 0)
            {
                return null;
            }

            ArticuloDTO articulo = _mapper.MapFromRow(res.Rows[0]);

            return articulo;

        }

        public List<ArticuloDTO> ObtenerTodos()
        {
            string query = @"SELECT 
                    A.Id AS Articulo_Id,
                    A.Codigo AS Articulo_Codigo,
                    A.Nombre AS Articulo_Nombre,
                    A.Descripcion AS Articulo_Descripcion,
                    A.Precio AS Articulo_Precio,
                    M.Id AS Marca_Id,
                    M.Descripcion AS Marca_Descripcion,
                    C.Id AS Categoria_Id,
                    C.Descripcion AS Categoria_Descripcion
                FROM ARTICULOS A
                JOIN MARCAS M ON A.IdMarca = M.Id
                JOIN CATEGORIAS C ON A.IdCategoria = C.Id;";

            DataTable res = _dbManager.ExecuteQuery(query);

            if (res.Rows.Count == 0)
            {
                return null;
            }

            var articulosList = _mapper.ListMapFromRow(res);

            return articulosList;
        }

        public bool Update(ArticuloDTO entity)
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
                    new SqlParameter("@Codigo", entity.Articulo.Codigo),
                    new SqlParameter("@Nombre", entity.Articulo.Nombre),
                    new SqlParameter("@Descripcion", entity.Articulo.Descripcion),
                    new SqlParameter("@IdMarca", entity.Articulo.IdMarca),
                    new SqlParameter("@IdCategoria", entity.Articulo.IdCategoria),
                    new SqlParameter("@Precio", entity.Articulo.Precio)
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
