using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEMenu
    {
        private int cod_menu;
        private int cod_receta;
        private string plato_menu;
        private string precio_menu;
        private string comentario_menu;

        public int Cod_menu { get => cod_menu; set => cod_menu = value; }
        public int Cod_receta { get => cod_receta; set => cod_receta = value; }
        public string Plato_menu { get => plato_menu; set => plato_menu = value; }
        public string Precio_menu { get => precio_menu; set => precio_menu = value; }
        public string Comentario_menu { get => comentario_menu; set => comentario_menu = value; }
    }
}
