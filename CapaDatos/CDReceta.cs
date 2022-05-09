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
    class CDReceta
    {
        Conexion oConexion = new Conexion();
        SqlCommand oCommand = new SqlCommand();
        public bool guardarReceta(CEReceta receta)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "ActualizarReceta";
                oCommand.Parameters.Add("@cod_receta", receta.Cod_receta);                            
                oCommand.Parameters.Add("@fuente_receta", receta.Fuente_receta);
                oCommand.Parameters.Add("@ubicacion_fisica_receta", receta.Ubicacion_fisica_receta);
                oCommand.Parameters.Add("@lista_ingredientes_receta", receta.Lista_ingredientes_receta);
                oCommand.Parameters.Add("@tiempo_ejecucion_receta", receta.Tiempo_ejecucion_receta);
                oCommand.Parameters.Add("@utensilios_receta", receta.Utensilios_receta);
                oCommand.Parameters.Add("@comentario_receta", receta.Comentario_receta);
                oCommand.Parameters.Add("@tiempo_receta", receta.Tiempo_receta);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
