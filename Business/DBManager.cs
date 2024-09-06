using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Business
{
    public class DBManager : IDisposable
    {
        private readonly string _connectionString;
        private SqlConnection _connection;

        /// <summary>
        /// Constructor sin parametros, obtiene la stringconnection desde la configuracion de la app.
        /// </summary>
        public DBManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString; ;
            _connection = new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Constructor con parametros para pasarle tu propio stringconnection
        /// </summary>
        public DBManager(string connectionString)
        {
            _connectionString = connectionString;
            _connection = new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Abre la conexion a base de datos
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al abrir la conexión.", ex);
                throw;
            }
        }

        /// <summary>
        /// Cierra la conexion a base de datos
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al cerrar la conexión.", ex);
                throw;
            }
        }

        /// <summary>
        /// Ejecuta una lectura a la base de datos (SELECT) y devuelve la tabla de datos obtenida.
        /// </summary>
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        return resultTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al ejecutar la consulta.", ex);
                throw;
            }
        }

        /// <summary>
        /// Ejecuta acciones (INSERT, UPDATE, DELETE) en la base de datos.
        /// </summary>
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al ejecutar la consulta de modificación.", ex);
                throw;
            }
        }

        /// <summary>
        /// Ejecuta una consulta Scalar (COUNT(*)) y devuelve un object con el resultado para ser convertido a conveniencia.
        /// </summary>
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, _connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                LogError("Error al ejecutar la consulta de valor escalar.", ex);
                throw;
            }
        }

        private void LogError(string message, Exception ex)
        {

            Console.WriteLine($"{message} Detalles: {ex.Message}");
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }


    }
}
