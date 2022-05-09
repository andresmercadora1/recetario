using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEReceta
    {
		private int cod_receta;
		private string fuente_receta;
		private string ubicacion_fisica_receta;
		private string lista_ingredientes_receta;
		private DateTime tiempo_ejecucion_receta;
		private string utensilios_receta;
		private string comentario_receta;
		private DateTime tiempo_receta;

        public int Cod_receta { get => cod_receta; set => cod_receta = value; }
        public string Fuente_receta { get => fuente_receta; set => fuente_receta = value; }
        public string Ubicacion_fisica_receta { get => ubicacion_fisica_receta; set => ubicacion_fisica_receta = value; }
        public string Lista_ingredientes_receta { get => lista_ingredientes_receta; set => lista_ingredientes_receta = value; }
        public DateTime Tiempo_ejecucion_receta { get => tiempo_ejecucion_receta; set => tiempo_ejecucion_receta = value; }
        public string Utensilios_receta { get => utensilios_receta; set => utensilios_receta = value; }
        public string Comentario_receta { get => comentario_receta; set => comentario_receta = value; }
        public DateTime Tiempo_receta { get => tiempo_receta; set => tiempo_receta = value; }
    }
}
