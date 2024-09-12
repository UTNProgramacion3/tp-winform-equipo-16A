using System;
using System.Collections.Generic;
using DataAccess;
using Domain.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Business.Servicios
{
    public class ImagenService
    {
        private DBManager dbManager;

        public ImagenService()
        {
            dbManager = new DBManager();
        }

        public List<Imagen> ObtenerListaDeImagenes(int IdArticulo)
        {
            string query = "SELECT * FROM IMAGENES WHERE IdArticulo = @IdArticulo";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdArticulo", IdArticulo)
                };

            try
            {
                dbManager.OpenConnection();
                DataTable tabla = dbManager.ExecuteQuery(query, parametros);


            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        public Imagen 
    }
}
