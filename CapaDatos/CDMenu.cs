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
    public class CDMenu
    {
        Conexion oConexion = new Conexion();
        SqlCommand oCommand = new SqlCommand();

        public bool guardarMenu(CEMenu menu)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "agregar_menu";
                oCommand.Parameters.AddWithValue("@cod_receta", menu.Cod_receta);
                oCommand.Parameters.AddWithValue("@plato_menu", menu.Precio_menu);
                oCommand.Parameters.AddWithValue("@precio_menu", menu.Precio_menu);
                oCommand.Parameters.AddWithValue("@comentario_menu", menu.Comentario_menu);    
                oCommand.ExecuteNonQuery();
                return true;
            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool modificarMenu(CEMenu menu)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "update_menu";
                oCommand.Parameters.AddWithValue("@cod_menu", menu.Cod_menu);
                oCommand.Parameters.AddWithValue("@cod_receta", menu.Cod_receta);
                oCommand.Parameters.AddWithValue("@plato_menu", menu.Precio_menu);
                oCommand.Parameters.AddWithValue("@precio_menu", menu.Precio_menu);
                oCommand.Parameters.AddWithValue("@comentario_menu", menu.Comentario_menu);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool eliminarMenu(CEMenu menu)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "delete_menu";
                oCommand.Parameters.AddWithValue("@cod_menu", menu.Cod_menu);
                oCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataSet consultarMenu(CEMenu menu)
        {
            try
            {
                oCommand.CommandType = CommandType.StoredProcedure;
                oCommand.Connection = oConexion.conectar("DBRecetario");
                oCommand.CommandText = "delete_menu";
                oCommand.Parameters.AddWithValue("@cod_menu", menu.Cod_menu);
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
