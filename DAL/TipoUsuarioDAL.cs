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
    public class TipoUsuarioDAL
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        ///Agregar tipo de usuario 
        public string GuardarTipoUsu(int nOpcion, TipoUsuarioET tipoUsuario)
        {
            ///Respuesta que se devolvera con el exito o fracaso al guardar el tipo usuario
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos
                SqlCommand Comando = new SqlCommand("Sp_GuardarTipoUsuario", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@IdTipoUsuario", SqlDbType.Int).Value = tipoUsuario.IdTipoUsuario;
                Comando.Parameters.Add("@nombre", SqlDbType.Float).Value = tipoUsuario.Nombre;
                Comando.Parameters.Add("@descripcion", SqlDbType.Float).Value = tipoUsuario.Descripcion;
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
        //Buscar todos los tipos de usuaro
        public DataTable ListaTipoUsuario(string cTexto)
        {
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos
                SqlCommand Comando = new SqlCommand("Sp_ListadoTipoUsuario", SqlCon);
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

        //Modificar tipo de usuario 
        public bool ActualizarTipoUsuario(TipoUsuarioET tipoUsuario)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conenxion con la BD
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar
                    SqlCommand comando = new SqlCommand("Sp_GuardarTipoUsuario", SqlCon);
                    comando.Connection = SqlCon;
                    //Se indica que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    //Nuevos parametros 
                    comando.Parameters.Add(new SqlParameter("@idTipoDescuento", tipoUsuario.IdTipoUsuario));
                    comando.Parameters.Add(new SqlParameter("@descripcion", tipoUsuario.Descripcion));
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

        //Buscar solo 1 tipo de usuario
        public DataTable BuscarTipoUsuario(string descripcion)
        {
            //Crear una instancia para crear un objeto de tipo dataTable
            DataTable retVal = new DataTable();

            {
                try
                {
                    //Abrir conexion con la base de datos
                    SqlCon.Open();
                    //Indicar cual procedimiento almacenado utilizar
                    SqlCommand comando = new SqlCommand("SpBuscarTipoUsuario", SqlCon);
                    comando.Connection = SqlCon;
                    comando.Parameters.Add(new SqlParameter("@descripcion", "%" + descripcion + "%"));
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
