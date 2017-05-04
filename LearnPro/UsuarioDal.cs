using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
namespace LearnPro
{
    class UsuarioDal
    {
        public static int CrearCuentas(string Usuario, string Contraseña)
        {
            int resultado = 0;
            SqlBd(Usuario);
            SqlConnection Conn = BDComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("insert into Usuarios (Nombre,Contraseña) values ('{0}',PwdEncrypt('{1}'))", Usuario, Contraseña), Conn);
            resultado = Comando.ExecuteNonQuery();
            Conn.Close();
            return resultado;
        }

        public static int Autentificar(string Usuario, string Contraseña)
        {
            int resultado = -1;
            SqlConnection conexion = BDComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("select * from Usuarios where Nombre = '{0}' and PwdCompare('{1}',Contraseña) = 1 ", Usuario, Contraseña), conexion);
            
            SqlDataReader read = Comando.ExecuteReader();

            while (read.Read()) {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }
        public static void SqlBd(string usuario)
        {
            SqlConnection conexion = BDComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("if exists (select * from sys.databases where [name] = 'Usuario') print 'exist'; else Create Database Usuario;IF OBJECT_ID (N'Usuarios', N'U') IS NOT NULL print 'exist'; else Create table Usuarios(id_u int not null identity,Nombre varchar(20),Contraseña varbinary(max));Use Usuario;"), conexion);
            SqlDataReader read = Comando.ExecuteReader();

            conexion.Close();

        }

        
    }
}
