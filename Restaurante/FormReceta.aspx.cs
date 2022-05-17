using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaEntidad;
using CapaNegocio;

namespace Restaurante
{
    public partial class FormReceta : System.Web.UI.Page
    {
        CNReceta objCNReceta = new CNReceta();
        CEReceta objCEReceta = new CEReceta();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            objCEReceta.Fuente_receta = txtFuenteRec.Text;
            objCEReceta.Ubicacion_fisica_receta = txtUbicacionFisica.Text;
            objCEReceta.Lista_ingredientes_receta = txtListaIng.Text;
            objCEReceta.Tiempo_ejecucion_receta = Convert.ToDateTime(txtTiempoEjec.Text);
            objCEReceta.Utensilios_receta = txtUtensilios.Text;
            objCEReceta.Comentario_receta = txtComentarios.Text;
            objCEReceta.Tiempo_receta = Convert.ToDateTime(txtTiempoPrep.Text);

            if (objCNReceta.guardarReceta(objCEReceta))
            {
                lblResultado.Text = "La receta se guardo correctamente";
            }
            else
            {
                lblResultado.Text = "Error al guardar la receta";
            }
        }
    }
}