using AutoresEditoriales_DB.EntityModel;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AutoresEditoriales_DB
{
    public class Repositorio
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionEditoriales"].ConnectionString);

        public List<editoriales> GetEditoriales() 
        {
            List<editoriales> listaEditoriales = new List<editoriales>();
            listaEditoriales = connection.Query<editoriales>("SELECT * FROM editoriales").ToList();
            return listaEditoriales;
        }

        public Respuesta insertaEditoriales(editoriales editoriales)
        {
            Respuesta rest = new Respuesta();           
            try
            {
                rest.Id = connection.Query<int>("sp_insertEditoriales", editoriales, commandType: System.Data.CommandType.StoredProcedure).SingleOrDefault();
                rest.Exitoso = true;
                rest.Mensaje = "Registro exitoso";
                return rest;
            }
            catch (Exception e)
            {
                rest.Exitoso = false;
                rest.Mensaje = e.Message;
                return rest;
            }
        }
    }


}