﻿using System;
using System.Collections.Generic;
using DataAccess;
using Domain.Entities;
using System.Data.SqlClient;
using System.Data;
using Utils;
using Utils.Interfaces;

namespace Business.Servicios
{
    public class ImagenService
    {
        private DBManager _dbManager;
        private IMapper<Imagen> _mapper;

        public ImagenService()
        {
            _dbManager = new DBManager();
            _mapper = new Mapper<Imagen>();
        }

        public List<Imagen> ObtenerImagenesPorArticulo(int idArticulo)
        {
            string query = @"Select * From IMAGENES Where IdArticulo = @IdArticulo";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdArticulo", idArticulo)
                };

            DataTable res = _dbManager.ExecuteQuery(query, parametros);

            if(res.Rows.Count == 0)
            {
                return null;
            }

            var imagenesList = _mapper.ListMapFromRow(res);

            return imagenesList;
        }

        public Imagen ObtenerImagenPortada(int idArticulo)
        {
            string query = @"Select TOP(1) * From IMAGENES Where IdArticulo = @IdArticulo Order By Id ASC";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdArticulo", idArticulo)
                };

            DataTable res = _dbManager.ExecuteQuery(query, parametros);

            if(res.Rows.Count == 0)
            {
                return null;
            }

            var imagen = _mapper.MapFromRow(res.Rows[0]);

            return imagen;
        }

        public bool EditarImagenPortada(int idArticulo, string nuevaUrl)
        {
            string query = @"Update IMAGENES
                             Set ImagenUrl = @NuevaUrl
                             Where Id = (
                                Select TOP(1) Id
                                From IMAGENES 
                                Where IdArticulo = @IdArticulo
                                Order By Id ASC);";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NuevaUrl", nuevaUrl),
                    new SqlParameter("@IdArticulo", idArticulo)
                };

            var res = _dbManager.ExecuteNonQuery(query, parametros);

            if(res == 0)
            {
                return false;
            }

            return true;
        }

        public bool EliminarImagen(int Id)
        {
            string query = @"Delete From IMAGENES Where Id = @Id";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", Id)
                };

            var res = _dbManager.ExecuteNonQuery(query, parametros);

            if(res == 0)
            {
                return false;
            }

            return true;

        }

        public bool EditarImagen(int Id, string nuevaUrl)
        {
            string query = @"Update IMAGENES 
                             SET ImagenUrl = @NuevaUrl
                             Where Id = @Id";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@Id", Id),
                    new SqlParameter("@NuevaUrl", nuevaUrl)
                };

            var res = _dbManager.ExecuteNonQuery(query, parametros);

            if (res == 0)
            {
                return false;
            }

            return true;
        }

        public bool Crear(int idArticulo, string imagenUrl)
        {
            string query = @"Insert into IMAGENES values (@IdArticulo, @ImagenUrl)";

            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdArticulo", idArticulo),
                    new SqlParameter("@ImagenUrl", imagenUrl)
                };

            var res = _dbManager.ExecuteNonQuery(query, parametros);

            if (res == 0)
            {
                return false;
            }

            return true;

        }

        public bool InsertLista(List<Imagen> imagenes)
        {
            foreach(Imagen img in imagenes)
            {
                if(img != null)
                {
                    var res = Crear(img.IdArticulo, img.ImagenUrl);

                    if(!res)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
