using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection conectar(String cnx)
        {
            try
            {
                SqlConnection oConectar = new SqlConnection(ConfigurationSettings.AppSettings[cnx].ToString());
                oConectar.Open();
                return oConectar;
            } catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
