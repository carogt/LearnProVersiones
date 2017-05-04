using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LearnPro
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
       {
           SqlConnection Conn = new SqlConnection("Server=USUARIO-PC\\HOME;Integrated Security=True;");
           Conn.Open();

           return Conn;

       }


    }
}
