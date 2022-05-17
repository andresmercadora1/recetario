using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CDReceta
    {
        Conexion oConexion = new Conexion();
        SqlCommand oCommand = new SqlCommand();
        public bool guardarReceta(CEReceta receta)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "agregar_receta";
                oCommand.Parameters.AddWithValue("@cod_receta", receta.Cod_receta);                            
                oCommand.Parameters.AddWithValue("@fuente_receta", receta.Fuente_receta);
                oCommand.Parameters.AddWithValue("@ubicacion_fisica_receta", receta.Ubicacion_fisica_receta);
                oCommand.Parameters.AddWithValue("@lista_ingredientes_receta", receta.Lista_ingredientes_receta);
                oCommand.Parameters.AddWithValue("@tiempo_ejecucion_receta", receta.Tiempo_ejecucion_receta);
                oCommand.Parameters.AddWithValue("@utensilios_receta", receta.Utensilios_receta);
                oCommand.Parameters.AddWithValue("@comentario_receta", receta.Comentario_receta);
                oCommand.Parameters.AddWithValue("@tiempo_receta", receta.Tiempo_receta);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool modificarReceta(CEReceta receta)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "update_receta";
                oCommand.Parameters.AddWithValue("@cod_receta", receta.Cod_receta);
                oCommand.Parameters.AddWithValue("@fuente_receta", receta.Fuente_receta);
                oCommand.Parameters.AddWithValue("@ubicacion_fisica_receta", receta.Ubicacion_fisica_receta);
                oCommand.Parameters.AddWithValue("@lista_ingredientes_receta", receta.Lista_ingredientes_receta);
                oCommand.Parameters.AddWithValue("@tiempo_ejecucion_receta", receta.Tiempo_ejecucion_receta);
                oCommand.Parameters.AddWithValue("@utensilios_receta", receta.Utensilios_receta);
                oCommand.Parameters.AddWithValue("@comentario_receta", receta.Comentario_receta);
                oCommand.Parameters.AddWithValue("@tiempo_receta", receta.Tiempo_receta);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool eliminarReceta(CEReceta receta)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "delete_receta";
                oCommand.Parameters.AddWithValue("@cod_receta", receta.Cod_receta);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataSet consultarReceta(CEReceta receta)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "consultar_receta";
                oCommand.Parameters.AddWithValue("@cod_receta", receta.Cod_receta);
                SqlDataAdapter dat = new SqlDataAdapter(oCommand);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
