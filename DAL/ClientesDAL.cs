using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ET;
using System.Data;

namespace DAL
{
    public class ClienteDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        //Ingresar un nuevo cliente
        public string AgregarCliiente(int nOpcion, ClienteET cliente)
        {
            //Respuesta que se devolvera con el exito o fracaso al guradar la cliente
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos 
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("sp_GuardarCliente", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = cliente.IdCliente;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = cliente.Nombre;
                Comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cliente.Cedula;
                Comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = cliente.Apellido;
                Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = cliente.Correo;
                Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = cliente.Telefono;;
                Rpta = Comando.ExecuteNonQuery() == 1 ? "Ok" : "No se logró registrar correctamente";
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

        //Buscar todos los clientes ingresados
        public DataTable ListaCliente(string cTexto)
        {
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos
                SqlCommand Comando = new SqlCommand("Sp_ListadoCliente", SqlCon);
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

        //Eliminar cliente
        public string EliminarCliente(int idCliente)
        {
            //Variable que indica si eliminado fue correcto o no tuvo exito
            string rpta = "";

            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar 
                SqlCommand comando = new SqlCommand("SP_EliminarCliente", SqlCon);
                //Le indico que el comando es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                //Se indica cual es el cliente eliminado
                comando.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
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

        //Modificar cliente 
        public bool ActualizarCliente(ClienteET cliente)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conexion con la base de datos
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar de la base de datos
                    SqlCommand comando = new SqlCommand("Sp_GuardarCliente", SqlCon);
                    comando.Connection = SqlCon;
                    //Le indico que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    //Nombre del dato                    //Tipo de dato
                    comando.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
                    comando.Parameters.Add(new SqlParameter("@cedula", cliente.Cedula));
                    comando.Parameters.Add(new SqlParameter("@idCliente", cliente.IdCliente));
                    comando.Parameters.Add(new SqlParameter("@apellido", cliente.Apellido));
                    comando.Parameters.Add(new SqlParameter("@correo", cliente.Correo));
                    comando.Parameters.Add(new SqlParameter("@telefono", cliente.Telefono));
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

        //Buscar solo 1 cliente
        public DataTable BuscarCliente(string nombre)
        {
            ///instancia para crear un objeto de tipo data table
            DataTable retVal = new DataTable();
            {
                try
                {
                    //Abrir la conexion con la base de datos
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar de la base de datos
                    SqlCommand comando = new SqlCommand("Sp_ListadoCliente", SqlCon);
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

