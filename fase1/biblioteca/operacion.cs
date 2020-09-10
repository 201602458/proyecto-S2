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
            try{
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
    }
}
