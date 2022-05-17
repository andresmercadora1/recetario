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
    public class CDPlato
    {
        Conexion oConexion = new Conexion();
        SqlCommand oCommand = new SqlCommand();
        public bool guardarPlato(CEPlato plato)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "ActualizarPlato";
                oCommand.Parameters.AddWithValue("@cod_plato", plato.Cod_plato);
                oCommand.Parameters.AddWithValue("@cod_receta", plato.Cod_receta);
                oCommand.Parameters.AddWithValue("@tipo_plato", plato.Tipo_plato);
                oCommand.Parameters.AddWithValue("@ingredientes_principal_plato", plato.Ingredientes_principal_plato);
                oCommand.Parameters.AddWithValue("@precio_plato", plato.Precio_plato);
                oCommand.Parameters.AddWithValue("@comentario_adicional_plato", plato.Comentario_adicional_plato);
                oCommand.Parameters.AddWithValue("@nombre_plato", plato.Nombre_plato);
                oCommand.Parameters.AddWithValue("@calorias_plato", plato.Calorias_plato);
                oCommand.Parameters.AddWithValue("@cant_util_ing_por_plato", plato.Cant_util_ing_por_plato);
                oCommand.Parameters.AddWithValue("@unidad_medida_por_plato", plato.Unidad_medida_por_plato);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool modificarPlato(CEPlato plato)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "update_plato";
                oCommand.Parameters.AddWithValue("@cod_plato", plato.Cod_plato);
                oCommand.Parameters.AddWithValue("@cod_receta", plato.Cod_receta);
                oCommand.Parameters.AddWithValue("@tipo_plato", plato.Tipo_plato);
                oCommand.Parameters.AddWithValue("@ingredientes_principal_plato", plato.Ingredientes_principal_plato);
                oCommand.Parameters.AddWithValue("@precio_plato", plato.Precio_plato);
                oCommand.Parameters.AddWithValue("@comentario_adicional_plato", plato.Comentario_adicional_plato);
                oCommand.Parameters.AddWithValue("@nombre_plato", plato.Nombre_plato);
                oCommand.Parameters.AddWithValue("@calorias_plato", plato.Calorias_plato);
                oCommand.Parameters.AddWithValue("@cant_util_ing_por_plato", plato.Cant_util_ing_por_plato);
                oCommand.Parameters.AddWithValue("@unidad_medida_por_plato", plato.Unidad_medida_por_plato);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool eliminarPlato(CEPlato plato)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "delete_plato";
                oCommand.Parameters.AddWithValue("@cod_plato", plato.Cod_plato);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataSet consultarPlato(CEPlato plato)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "consultar_plato";
                oCommand.Parameters.AddWithValue("@cod_plato", plato.Cod_plato);
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
