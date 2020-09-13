using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace biblioteca
{
    public class operacion
    {
        conexion con = new conexion();
        public bool registrar(string nombre, string apellido, string usu, string contra, string fecha_nac, string email, int id_pais)
        {
            try {
                string sql = "INSERT INTO usuario VALUES('" + nombre + "','" + apellido + "','" + usu + "','" + contra + "','" + fecha_nac + "', '" + email + "'," + id_pais + ")";

                SqlCommand cm = new SqlCommand(sql, con.getConexion());
                int n = cm.ExecuteNonQuery();
                return n > 0;

            }
            catch (Exception)
            {

                return false;
            }


        }

        //****

        //conexion con = new conexion();

        public String ingresar(String nombre, String contra)
        {
           // String que = "1";
            try {
                String dato = "";
                String name = "select * from usuario where nick = '" + nombre + "' AND contra ='" + contra + "'";
                SqlCommand cm = new SqlCommand(name, con.getConexion());
                cm.Parameters.AddWithValue("@nick", nombre);
                SqlDataReader consu = cm.ExecuteReader();
                if (consu.Read()) {
                    dato = consu["idUsu"].ToString();

                }
                return dato;




            }
            catch (Exception)
            {

                return "no";
            }

           /* try
            {
                String name = "select nombre from usuario where nick = '" + nombre + "' AND contra ='"+contra+"'";
                //String pass = "select contra from usuario where contra = '" + contra + "'";

                SqlCommand cm = new SqlCommand(name, con.getConexion());
                int n = cm.ExecuteNonQuery();


                return name;

            }
            catch (Exception)
            {

                return null;
            }*/

        }

        
    }
   
}
