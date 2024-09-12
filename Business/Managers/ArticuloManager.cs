using DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Business.Managers
{
    public class ArticuloManager : ICrudRepository<Articulo>
    {
        private DBManager dbManager;

        public ArticuloManager()
        {
            dbManager = new DBManager();
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

            try
            {
                dbManager.OpenConnection();
                int creado = dbManager.ExecuteNonQuery(query, parametros);

                return creado >= 1;


            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbManager.CloseConnection();
            }
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

            try
            {
                dbManager.OpenConnection();
                int eliminado = dbManager.ExecuteNonQuery(query, parametros);

                return eliminado >= 1;

            }catch (Exception ex)
            {
                throw ex;
                
            }finally
            {
                dbManager.CloseConnection();
            }
        }
        public Articulo ObtenerPorId(int id)
        {
            string query = @"Select * From ARTICULO Where Id = @Id";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", id)
                };

            try
            {
                dbManager.OpenConnection();
                DataTable tabla = dbManager.ExecuteQuery(query, parametros);
                Articulo art = ConvertirRowEnArticulo(tabla.Rows[0]);

                return art;

            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        public List<Articulo> ObtenerTodos()
        {
            List<Articulo> lista = new List<Articulo>();
            string query = @"Select * from ARTICULOS";

            try
            {
                dbManager.OpenConnection();
                DataTable tabla = dbManager.ExecuteQuery(query);

                foreach(DataRow row in tabla.Rows)
                {
                    Articulo art = ConvertirRowEnArticulo(row);
                    lista.Add(art);
                }

                return lista;

            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbManager.CloseConnection();
            }

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

            try
            {
                dbManager.OpenConnection();
                int updated = dbManager.ExecuteNonQuery(query, parametros);

                return updated >= 1;

            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbManager.CloseConnection();
            }

        }

        public Articulo ConvertirRowEnArticulo(DataRow row)
        {
            var Id = Convert.ToInt32(row["Id"]);
            var Codigo = row["Codigo"].ToString();
            var Nombre = row["Nombre"].ToString();
            var Descripcion = row["Descripcion"].ToString();
            var IdMarca = Convert.ToInt32(row["IdMarca"]);
            var IdCategoria = Convert.ToInt32(row["IdCategoria"]);
            var Precio = Convert.ToDecimal(row["Precio"]);

            return new Articulo(Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio);
        }

       
    }
}
