using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using biblioteca;
using System.Data.SqlClient;

namespace fase1.pagina
{
    public partial class registro : System.Web.UI.Page
    {
        conexion con = new conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            llenar();
        }

        private void llenar() {
            string sql = "select * from paises";
            SqlCommand cm = new SqlCommand(sql, con.getConexion());         
           // cm.Parameters.AddWithValue("@n", nombre);
            //SqlDataReader consu = cm.ExecuteReader();
            Tpais.DataSource = cm.ToString();
            Tpais.DataTextField = "nombre";
            Tpais.DataValueField = "id";
           //pais.DataBind();
            Tpais.Items.Insert(0,new ListItem("Seleccionar","0"));
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
            pais = 55;
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