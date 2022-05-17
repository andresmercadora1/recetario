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
    public class CNMenu
    {
        CDMenu objDatoMenu = new CDMenu();

        public bool guardarMenu(CEMenu menu)
        {
            return objDatoMenu.guardarMenu(menu);
        }

        public bool modificarMenu(CEMenu menu)
        {
            return objDatoMenu.modificarMenu(menu);
        }

        public bool eliminarMenu(CEMenu menu)
        {
            return objDatoMenu.eliminarMenu(menu);
        }

        public DataSet consultarMenu(CEMenu menu)
        {
            return objDatoMenu.consultarMenu(menu);
        }
    }
}
