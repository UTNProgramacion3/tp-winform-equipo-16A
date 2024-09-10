using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class ArticuloManager
    {
        private DBManager dbManager;

        public ArticuloManager()
        {
            dbManager = new DBManager();
        }

        public string ObtenerNombreArticuloPorId(int id)
        {
            try
            {
                dbManager.OpenConnection();

                DataTable tabla = dbManager.ExecuteQuery($"Select Nombre From ARTICULOS where Id = {id}");

                if (tabla.Rows.Count > 0)
                {
                    return tabla.Rows[0]["Nombre"].ToString();
                }
                else
                {
                    return "Artículo no encontrado";
                }
            }
            catch (Exception ex)
            {
                // Manejar el error de manera más amigable para la capa UI
                throw new Exception("Error al obtener el artículo.", ex);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }
    }
}
