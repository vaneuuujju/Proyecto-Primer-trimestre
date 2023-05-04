using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class UsuarioDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        //Agregaar usuario 
        public string GuardarUsuario(int nOpcion, UsuarioET usuario)
        {
            //Respuesta que se devolvera con el exito o fracaso al guradar la cliente
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos 
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("Sp_GuardarUsuario", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = usuario.IdUsuario;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.Nombre;
                Comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = usuario.Apellido;
                Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = usuario.Correo;
                Comando.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = usuario.Contrasenna;
                Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = usuario.Direccion;
                Comando.Parameters.Add("@idTipoUsuario", SqlDbType.Int).Value = usuario.IdTipoUsuario;
                Rpta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se logró guardar correctamente";
                //Abro la conexion a la base
                SqlCon.Open();
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                //Si la conexcion esta abierta, entonces que cierre la conexion
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        /////Buscar todos los usuarios ingresados
        public DataTable ListaUsuario(string cTexto)
        {
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos
                SqlCommand Comando = new SqlCommand("Sp_ListadoUsuario", SqlCon);
                //Le indico que el comando es un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Se envia todo el texto almacenado
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                //Se abre la conexion con la base de datos
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                //Se cierra la conexion a la base en caso de que siga abierta
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        //Eliminar usuario
        public string EliminarUsuario(int idUsuario)
        {
            //Variable que indica si eliminado fue correcto o no tuvo exito
            string rpta = "";

            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar
                SqlCommand comando = new SqlCommand("SP_EliminarUsuario", SqlCon);
                //Le indico que el comando es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                //Se indica cual es el cliente eliminado
                comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                //Se abre la conexcion
                SqlCon.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "Ok" : "No se logro eliminar correctamente";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                //Si la conexion esta abierta se cierra 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //Modificar usuario 
        public bool ActualizarUsuario(UsuarioET usuario)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conexion con la base de datos
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar de la base de datos
                    SqlCommand comando = new SqlCommand("Sp_GuardarUsuario", SqlCon);
                    comando.Connection = SqlCon;
                    //Le indico que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    //Nombre del dato                    //Tipo de dato
                    comando.Parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
                    comando.Parameters.Add(new SqlParameter("@idUsuario", usuario.IdUsuario));
                    comando.Parameters.Add(new SqlParameter("@direccion", usuario.Direccion));
                    comando.Parameters.Add(new SqlParameter("@contrasena", usuario.Contrasenna));
                    comando.Parameters.Add(new SqlParameter("@apellido", usuario.Apellido));
                    comando.Parameters.Add(new SqlParameter("@correo", usuario.Correo));
                    comando.Parameters.Add(new SqlParameter("@idTipoUsuario", usuario.IdTipoUsuario));
                    SqlDataReader reader = comando.ExecuteReader();
                    reader.Close();
                    retVal = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    retVal = false;
                }
            }
            return retVal;
        }

        //Buscar solo 1 usuario
        public DataTable BuscarUsuario(string nombre)
        {
            ///instancia para crear un objeto de tipo data table
            DataTable retVal = new DataTable();
            {
                try
                {
                    //Abrir la conexion con la base de datos
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar de la base de datos
                    SqlCommand comando = new SqlCommand("SpBuscarUsuario", SqlCon);
                    comando.Connection = SqlCon;
                    //Parametros devueltos
                    comando.Parameters.Add(new SqlParameter("@nombre", "%" + nombre + "%"));
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = comando;
                    da.Fill(retVal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return retVal;
        }
    }
}