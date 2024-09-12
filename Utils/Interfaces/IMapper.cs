using System;
using System.Data;

namespace Utils.Interfaces
{
    public interface IMapper<T> where T : class, new()
    {
        T MapFromRow(DataRow row);
    }
}
