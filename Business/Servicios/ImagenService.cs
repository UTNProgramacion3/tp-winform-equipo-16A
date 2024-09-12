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

    }
}
