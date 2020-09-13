using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using biblioteca;
using System.IO;
using System.Diagnostics;

namespace fase1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            operacion op = new operacion();
            if (op.ingresar(Tusu.Text, Tcontra.Text)!= null) {
                Response.Write("<script>window.alert('"+ op.ingresar(Tusu.Text, Tcontra.Text) + "')</script>");

                Response.Write("<script>");
                Response.Write("window.open('inicio.aspx' ,'_blank')");
                Response.Write("</script>");


            }
            else
            {


            }

        }
    }
}