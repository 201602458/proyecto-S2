using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace fase1.pagina
{
    public partial class inicio : System.Web.UI.Page
    {
        //protected System.Web.UI.HtmlControls.HtmlInputFile oFile;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Bup.Visible = true;
            Bsubir.Visible = true;
            Tvista.Visible = true;
            
        }

        protected void Bup_Click(object sender, EventArgs e)
        {

            string leer = "";
            if (Bsubir.HasFile)
            {
                string ext = System.IO.Path.GetExtension(Bsubir.FileName);
                ext = ext.ToLower();

                if (ext == ".xml")
                {
                    //C:\Users\Calderon\Desktop\prueba.xml

                    Bsubir.SaveAs(Server.MapPath("~/pagina/subido/" + Bsubir.FileName));

                    leer = Server.MapPath("~/pagina/subido/" + Bsubir.FileName);
                    //leer = System.IO.File.ReadAllText(Server.MapPath("~/pagina/subido/" + Bsubir.FileName));
                    //leer = StreamReader("~/pagina/subido/" + Bsubir.FileName));
                    //Response.Write(leer);


                }
                else
                {
                    Response.Write("1no");
                }
            }
            else
            {
                Response.Write("2no");
            }

            try {
                XmlTextReader reader = new XmlTextReader(leer);
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            Tvista.Text += ("<" + reader.Name);
                            Tvista.Text += (">");
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            Tvista.Text += (reader.Value);
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            Tvista.Text += ("</" + reader.Name);
                            Tvista.Text += (">");
                            break;
                    }

                    //Tvista.Text += "\r";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>window.alert('no ok')</script>");
            }


            

           
        // Do some work here on the data.
        //Tvista.Text += reader.Name;
       // Response.Write(reader.Name);



    }//

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Write("<script>");
            Response.Write("window.open('juego.aspx' ,'_blank')");
            Response.Write("</script>");
        }
    }
}