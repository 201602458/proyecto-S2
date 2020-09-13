using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fase1.pagina
{
    public partial class juego : System.Web.UI.Page
    {
        static int turnos = 1;
        //fila(1)-columna(A)-color
        public static string[,] pos = new string[8,8];
     

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Write("<script>");
            Response.Write("window.open('juego.aspx' ,'_blank')");
            Response.Write("</script>");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>");
            Response.Write("window.open('inicio.aspx' ,'_blank')");
            Response.Write("</script>");

        }


        protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
        {          
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 0] = "blanca";

            }
            else {
                Label1.Text = "Turno de: Negra";
                pos[0, 0] = "negra";
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 1] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 1] = "negra";
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 2] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 2] = "negra";
            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 3] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 3] = "negra";
            }
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 4] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 4] = "negra";
            }
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 5] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 5] = "negra";
            }

        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 6] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 6] = "negra";
            }
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[0, 7] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[0, 7] = "negra";
            }
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 0] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 0] = "negra";
            }
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 1] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 1] = "negra";
            }
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 2] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 2] = "negra";
            }
        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 3] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 3] = "negra";
            }
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 4] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 4] = "negra";
            }
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 5] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 5] = "negra";
            }
        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 6] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 6] = "negra";
            }
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[1, 7] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[1, 7] = "negra";
            }
        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 0] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 0] = "negra";
            }
        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 1] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 1] = "negra";
            }
        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 2] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 2] = "negra";
            }
        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 3] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 3] = "negra";
            }
        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 4] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 4] = "negra";
            }
        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 5] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 5] = "negra";
            }
        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 6] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 6] = "negra";
            }
        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[2, 7] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[2, 7] = "negra";
            }
        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 0] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 0] = "negra";
            }
        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 1] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 1] = "negra";
            }

        }

        protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 2] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 2] = "negra";
            }
        }

        protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
        {
            
                pos[3, 3] = "blanca";

            
        }

        protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
        {
            pos[3, 4] = "negra";
        }

        protected void ImageButton30_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 5] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 5] = "negra";
            }
        }

        protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 6] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 6] = "negra";
            }
        }

        protected void ImageButton32_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[3, 7] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[3, 7] = "negra";
            }
        }

        protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 0] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 0] = "negra";
            }
        }

        protected void ImageButton34_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 1] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 1] = "negra";
            }
        }

        protected void ImageButton35_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 2] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 2] = "negra";
            }
        }

        protected void ImageButton36_Click(object sender, ImageClickEventArgs e)
        {
            pos[4, 3] = "negra";
        }

        protected void ImageButton37_Click(object sender, ImageClickEventArgs e)
        {
            pos[4, 4] = "blanca";
        }

        protected void ImageButton38_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 5] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 5] = "negra";
            }
        }

        protected void ImageButton39_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 6] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 6] = "negra";
            }
        }

        protected void ImageButton40_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[4, 7] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[4, 7] = "negra";
            }
        }

        protected void ImageButton41_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 0] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 0] = "negra";
            }
        }

        protected void ImageButton42_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 1] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 1] = "negra";
            }
        }

        protected void ImageButton43_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 2] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 2] = "negra";
            }
        }

        protected void ImageButton44_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 3] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 3] = "negra";
            }
        }

        protected void ImageButton45_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 4] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 4] = "negra";
            }
        }

        protected void ImageButton46_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 5] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 5] = "negra";
            }
        }

        protected void ImageButton47_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 6] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 6] = "negra";
            }
        }

        protected void ImageButton48_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[5, 7] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[5, 7] = "negra";
            }
        }

        protected void ImageButton49_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 0] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 0] = "negra";
            }
        }

        protected void ImageButton50_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 1] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 1] = "negra";
            }
        }

        protected void ImageButton51_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 2] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 2] = "negra";
            }
        }

        protected void ImageButton52_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 3] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 3] = "negra";
            }
        }

        protected void ImageButton53_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 4] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 4] = "negra";
            }
        }

        protected void ImageButton54_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 5] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 5] = "negra";
            }
        }

        protected void ImageButton55_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 6] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 6] = "negra";
            }
        }

        protected void ImageButton56_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[6, 7] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[6, 7] = "negra";
            }
        }

        protected void ImageButton57_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 0] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 0] = "negra";
            }
        }

        protected void ImageButton58_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 1] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 1] = "negra";
            }
        }

        protected void ImageButton59_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 2] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 2] = "negra";
            }
        }

        protected void ImageButton60_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 3] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 3] = "negra";
            }
        }

        protected void ImageButton61_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 4] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 4] = "negra";
            }
        }

        protected void ImageButton62_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 5] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 5] = "negra";
            }
        }

        protected void ImageButton63_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 6] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 6] = "negra";
            }

        }

        protected void ImageButton64_Click(object sender, ImageClickEventArgs e)
        {
            turnos++;
            if ((turnos % 2).Equals(0))
            {
                Label1.Text = "Turno de: Blanca";
                pos[7, 7] = "blanca";

            }
            else
            {
                Label1.Text = "Turno de: Negra";
                pos[7, 7] = "negra";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            
                //si hay una archivo.
                string nombreArchivo = Bsubir.FileName;
                string ruta = "~/guardado/" + nombreArchivo;
                Bsubir.SaveAs(Server.MapPath(ruta));

                pos[3, 3] = "blanca";
                pos[3, 4] = "negra";
                pos[4, 3] = "negra";
                pos[4, 4] = "blanca";
                crear c = new crear();
                c.generar(Server.MapPath(ruta));


            
            

           
            //String dubir =Bsubir.SaveAs(Bsubir.FileName));
        }
    }

    
}
