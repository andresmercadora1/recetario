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
    public class CNPlato
    {
        CDPlato objDatoPlato = new CDPlato();

        public bool guardarPlato(CEPlato plato)
        {
            return objDatoPlato.guardarPlato(plato);
        }

        public bool modificarPlato(CEPlato plato)
        {
            return objDatoPlato.modificarPlato(plato);
        }

        public bool eliminarPlato(CEPlato plato)
        {
            return objDatoPlato.eliminarPlato(plato);
        }

        public DataSet consultarPlato(CEPlato plato)
        {
            return objDatoPlato.consultarPlato(plato);
        }
    }
}
