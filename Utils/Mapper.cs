using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using Utils.Interfaces;

namespace Utils
{
    public class Mapper<T> : IMapper<T> where T : class, new()
    {
        public T MapFromRow(DataRow row)
        {
            T obj = new T();
            Type type = typeof(T); // Obtiene el tipo de T directamente
            PropertyInfo[] properties = type.GetProperties();

            foreach (var prop in properties)
            {
                // Validamos si la propiedad existe en la tabla y si puede escribirse
                if (row.Table.Columns.Contains(prop.Name) && prop.CanWrite)
                {
                    // Obtener el valor de la columna
                    object value = row[prop.Name];

                    // Manejar valores nulos
                    if (value != DBNull.Value)
                    {
                        // Convertir el valor al tipo de la propiedad
                        object convertedValue = Convert.ChangeType(value, prop.PropertyType);
                        prop.SetValue(obj, convertedValue);
                    }
                }
            }
            // Retornamos el objeto con los valores asignados
            return obj;
        }
        public List<T> ListMapFromRow(DataTable row)
        {
            List<T> objList = new List<T>();

            //Iteramos cada row de la tabla:
            foreach (DataRow r in row.Rows)
            {
                //Y utilizamos el método que ya tenemos para mapear:
                var res = MapFromRow(r);
                objList.Add(res);
            }

            return objList;
        }
    }
}
