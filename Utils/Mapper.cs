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
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            foreach (var prop in properties)
            {
                if (row.Table.Columns.Contains(prop.Name) && prop.CanWrite)
                {
                    object value = row[prop.Name];
                    if (value != DBNull.Value)
                    {
                        object convertedValue = Convert.ChangeType(value, prop.PropertyType);
                        prop.SetValue(obj, convertedValue);
                    }
                }
                else if (prop.PropertyType.IsClass && prop.PropertyType != typeof(string))
                {
                    object nestedObj = Activator.CreateInstance(prop.PropertyType);
                    PropertyInfo[] nestedProperties = prop.PropertyType.GetProperties();

                    foreach (var nestedProp in nestedProperties)
                    {
                        if (row.Table.Columns.Contains(nestedProp.Name) && nestedProp.CanWrite)
                        {
                            object nestedValue = row[nestedProp.Name];
                            if (nestedValue != DBNull.Value)
                            {
                                object convertedNestedValue = Convert.ChangeType(nestedValue, nestedProp.PropertyType);
                                nestedProp.SetValue(nestedObj, convertedNestedValue);
                            }
                        }
                    }

                    prop.SetValue(obj, nestedObj);
                }
            }

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
