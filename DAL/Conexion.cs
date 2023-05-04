using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {
        //Nombre de la base de datos
        private string Base;
        //Nombre del servidor
        private string Server;
        //Si se usan las credenciales de windows o credenciales de SQL
        private bool Seguridad;
        //Donde se va a guardar el string de conexion
        private static Conexion Con = null;
        public Conexion()
        {
            this.Base = "Facturacion";
            //ESTO SE TIENE Q CAMBIAR DEPENDIENDO DEL DISPOSITIVO
            this.Server = "LAPTOP-LFN9OOQI";
            //true: windows, false: sql
            this.Seguridad = true;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Server + ";Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    cadena.ConnectionString += "Integrated Security=SSPI";
                }
                else
                {
                    //Aca se completaría en caso de ser con usuario y contrasena de SQL
                    //cadena.ConnectionString += "User Id=" + this.Usuario;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
