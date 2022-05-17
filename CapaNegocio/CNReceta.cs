using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class CNReceta
    {
        CDReceta objDatoReceta = new CDReceta();

        public bool guardarReceta(CEReceta receta)
        {
            return objDatoReceta.guardarReceta(receta);
        }

        public bool modificarReceta(CEReceta receta)
        {
            return objDatoReceta.modificarReceta(receta);
        }

        public bool eliminarReceta(CEReceta receta)
        {
            return objDatoReceta.eliminarReceta(receta);
        }

        public DataSet consultarReceta(CEReceta receta)
        {
            return objDatoReceta.consultarReceta(receta);
        }
    }
}
