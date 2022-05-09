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
                oCommand.CommandText = "ActualizarMenu";
                oCommand.Parameters.Add("@cod_menu", menu.Cod_menu);
                oCommand.Parameters.Add("@cod_receta", menu.Cod_receta);
                oCommand.Parameters.Add("@plato_menu", menu.Precio_menu);
                oCommand.Parameters.Add("@precio_menu", menu.Precio_menu);
                oCommand.Parameters.Add("@comentario_menu", menu.Comentario_menu);    
                oCommand.ExecuteNonQuery();
                return true;
            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
