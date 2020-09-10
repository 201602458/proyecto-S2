using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using biblioteca;

namespace fase1.pagina
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            operacion op = new operacion();
            string nombre, apellido, usu, contra, contra2, fecha_nac, correo;
            int pais;
            nombre = Tnombre.Text;
            apellido = Tapellido.Text;
            usu = Tusu.Text;
            contra = Tcontra.Text;
            contra2 = Tcontra2.Text;
            fecha_nac = TfechaNac.Text;
            correo = Tcorreo.Text;
            pais = int.Parse(Tpais.Text);
            if (contra.Equals(contra2))
            {
                if (op.registrar(nombre, apellido, usu, contra, fecha_nac, correo, pais))
                {
                    Response.Write("<script>window.alert('Guardado Correctamente')</script>");
                }
                else
                {
                    Response.Write("<script>window.alert('Error al Guardar')</script>");
                }

            }
            else { Response.Write("<script>window.alert('Contrasenas no Coinsiden')</script>"); }
        }
    }
}