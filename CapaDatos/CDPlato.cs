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
                oCommand.Parameters.Add("@cod_plato", plato.Cod_plato);
                oCommand.Parameters.Add("@cod_receta", plato.Cod_receta);
                oCommand.Parameters.Add("@tipo_plato", plato.Tipo_plato);
                oCommand.Parameters.Add("@ingredientes_principal_plato", plato.Ingredientes_principal_plato);
                oCommand.Parameters.Add("@precio_plato", plato.Precio_plato);
                oCommand.Parameters.Add("@comentario_adicional_plato", plato.Comentario_adicional_plato);
                oCommand.Parameters.Add("@nombre_plato", plato.Nombre_plato);
                oCommand.Parameters.Add("@calorias_plato", plato.Calorias_plato);
                oCommand.Parameters.Add("@cant_util_ing_por_plato", plato.Cant_util_ing_por_plato);
                oCommand.Parameters.Add("@unidad_medida_por_plato", plato.Unidad_medida_por_plato);
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
