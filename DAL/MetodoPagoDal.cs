using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using ET;
using System.Threading.Tasks;

namespace DAL
{
    public class MetodoPagoDal
    {
        //Lee un flujo de lineas
        SqlDataReader Resultado;
        ///Donde se va guardar los datos tablas
        DataTable tabla = new DataTable();
        //objeto instanciado para la conexion a la base de datos
        SqlConnection SqlCon = new SqlConnection();

        //Agregar un metodo de pago
        public string GuardarMetodoPago(int nOpcion, MetoPagoET metodoPago)
        {
            //Respuesta que se devolvera con el exito o fracaso al guardar el metodo de pago
            string Rpta = "";
            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado a utilizar de la base de datos 
                SqlCommand Comando = new SqlCommand("Sp_GuardarMetodoPago", SqlCon);
                //Le indico que el comando es un procedimiento almacenado 
                Comando.CommandType = CommandType.StoredProcedure;
                //Nombre del dato                    //Tipo de dato
                Comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                Comando.Parameters.Add("@IdTipoPago", SqlDbType.Int).Value = metodoPago.IdTipoPago;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = metodoPago.Descripcion;
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

        //Buscar todos los metodos de pago
        public DataTable ListaMetodoPago(string cTexto)
        {
            try
            {
                //Se crea una conexion a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar
                SqlCommand Comando = new SqlCommand("USP_Listado_metodoPago", SqlCon);
                //Se indica que el comando es para un procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Se indica traer todo el texto almacenado
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                //Se abre la conexion
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                tabla.Load(Resultado);
                //Se retrona toda la tabla 
                return tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                //Se indica que si la conexión esta abierta, que se cierre 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        //Eliminar descuento
        public string EliminarMetodoPago(int idDescuento)
        {
            //Variable que indica si eliminado fue correcto o no tuvo exito
            string rpta = "";

            try
            {
                //En esta linea se crea la conexión a la base de datos
                SqlCon = Conexion.GetInstancia().CrearConexion();
                //Se indica cual procedimiento almacenado utilizar 
                SqlCommand comando = new SqlCommand("SP_EliminarMetodoPago", SqlCon);
                //Le indico que el comando es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                //Se indica cual es el metodo de pago eliminado
                comando.Parameters.Add("@idMetodoPago", SqlDbType.Int).Value = idDescuento;
                //Se abrio la conencion con la BD
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

        //Modificar descuento 
        public bool ActualizarMetodoPago(MetoPagoET metodoPago)
        {
            bool retVal = false;
            {
                try
                {
                    //Se abre la conenxion con la BD
                    SqlCon.Open();
                    //Se indica cual procedimiento almacenado a utilizar
                    SqlCommand comando = new SqlCommand("Sp_GuardarMetodoPago", SqlCon);
                    comando.Connection = SqlCon;
                    //Se indica que el comando es un procedimiento almacenado
                    comando.CommandType = CommandType.StoredProcedure;

                    //Nuevos parametros 

                    comando.Parameters.Add(new SqlParameter("@descripcion", metodoPago.Descripcion));
                    comando.Parameters.Add(new SqlParameter("@idMetodoPago", metodoPago.IdTipoPago));
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

        //Buscar solo 1 producto
        public DataTable BuscarMetodoPago(string descripcion)
        {
            //Crear una instancia para crear un objeto de tipo dataTable
            DataTable retVal = new DataTable();
            {
                try
                {
                    //Abrir conexion con la base de datos
                    SqlCon.Open();
                    //Indicar cual procedimiento almacenado utilizar
                    SqlCommand comando = new SqlCommand("Sp_ListadoMetodoPago", SqlCon);
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
